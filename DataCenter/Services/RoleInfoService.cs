using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using AutoMapper;
using DataCenter.Entities;
using DataCenter.Model;
using System.Security.Cryptography;
using System.Text;

namespace DataCenter.Services
{
    public static class MD5Extension
    {
        public static string ToMD5(this string orgStr)
        {
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(orgStr));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }

    public class RoleInfoService
    {
        

        public RoleInfoDto GetInitial()
        {
            try
            {
                using (var scope = new PressDBEntities())
                {
                    var item = scope.RoleInfo.Where(x=>x.Level==5 && x.IsDel==false).FirstOrDefault();

                    return new RoleInfoDto()
                    {
                        Id=item.Id,
                        Name=item.Name,
                        Level=item.Level,
                        CreateDateTime=item.CreateDateTime,
                        isDel=item.IsDel
                    };
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public ObservableCollection<RoleInfoDto> GetRoleInfos(int level)
        {
            ObservableCollection<RoleInfoDto> infos = new ObservableCollection<RoleInfoDto>();

            try
            {
                using (var scope = new PressDBEntities())
                {
                    var list = scope.RoleInfo.Where(x => x.Level >= level && x.IsDel == false).ToList();

                    list.ForEach(x => infos.Add(new RoleInfoDto()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Level = x.Level,
                        CreateDateTime = x.CreateDateTime,
                        isDel = x.IsDel
                    }));

                }

                return infos;
            }
            catch
            {
                return null;
            }
        }

        public bool AuthR(int level, string password)
        {
            try
            {
                using (var scope = new PressDBEntities())
                {
                    var item = scope.RoleInfo.Where(x => x.Level >= level && x.IsDel == false).FirstOrDefault();

                    if(item!=null)
                    {
                        var temp = password.ToMD5();
                        if (item.Password == password.ToMD5())
                        {
                            return true;
                        }
                    }

                }

                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}

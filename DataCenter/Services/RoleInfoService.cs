using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using AutoMapper;
using DataCenter.Entities;
using DataCenter.Model;

namespace DataCenter.Services
{
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

    }
}

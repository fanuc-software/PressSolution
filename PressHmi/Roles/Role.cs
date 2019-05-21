using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;
using FanucCnc.Model;
using FanucCnc.Enum;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using DataCenter.Model;
using DataCenter.Services;

namespace PressHmi.Roles
{
    public class Role
    {
        private static Role _instance = null;

        public static Role CreateInstance()
        {
            if (_instance == null)

            {
                _instance = new Role();
            }
            return _instance;
        }

        private RoleInfoDto curRole;
        public RoleInfoDto CurRole
        {
            get
            {
                return curRole;
            }
            set
            {
                curRole = value;
            }
        }
        
        public Role()
        {
            Initial();
        }

        public void Initial()
        {
            var srv = new RoleInfoService();
            CurRole = srv.GetInitial();
        }
    }
}

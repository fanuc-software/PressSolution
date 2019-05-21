using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace DataCenter.Model
{
    public class RoleInfoDto : ViewModelBase
    {
        public string id;

        public string Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged(() => Id);
                }
            }
        }


        public string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        public int level;
        public int Level
        {
            get { return level; }
            set
            {
                if (level != value)
                {
                    level = value;
                    RaisePropertyChanged(() => Level);
                }
            }
        }

        public string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    RaisePropertyChanged(() => Password);
                }
            }
        }


        public System.DateTime createDateTime;
        public System.DateTime CreateDateTime
        {
            get { return createDateTime; }
            set
            {
                if (createDateTime != value)
                {
                    createDateTime = value;
                    RaisePropertyChanged(() => CreateDateTime);
                }
            }
        }

        public bool isDel;
        public bool IsDel
        {
            get { return isDel; }
            set
            {
                if (isDel != value)
                {
                    isDel = value;
                    RaisePropertyChanged(() => IsDel);
                }
            }
        }

    }
}

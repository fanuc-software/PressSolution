using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class RecipesInfoItemDto : ViewModelBase
    {
        private string m_Id;
        public string Id
        {
            get { return m_Id; }
            set
            {
                if (m_Id != value)
                {
                    m_Id = value;
                    RaisePropertyChanged(() => Id);
                }
            }
        }

        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set
            {
                if (m_Name != value)
                {
                    m_Name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        private bool? m_IsConsistent;
        public bool? IsConsistent
        {
            get { return m_IsConsistent; }
            set
            {
                if (m_IsConsistent != value)
                {
                    m_IsConsistent = value;

                    if (m_IsConsistent == null) IsConsistentStr = null;
                    else if (m_IsConsistent == true) IsConsistentStr = "&#xf00c;";
                    else IsConsistentStr = "&#xf00d;";

                    RaisePropertyChanged(() => IsConsistent);
                }
            }
        }

        private string m_IsConsistentStr;
        public string IsConsistentStr
        {
            get { return m_IsConsistentStr; }
            set
            {
                //if (m_IsConsistent == null) m_IsConsistentStr = null;
                //else if (m_IsConsistent == true) m_IsConsistentStr = "&#xf00c;";
                //else m_IsConsistentStr = "&#xf00d;";
                m_IsConsistentStr = value;
                RaisePropertyChanged(() => IsConsistentStr);
            }
        }

        private string m_Value;
        public string Value
        {
            get { return m_Value; }
            set
            {
                if (m_Value != value)
                {
                    m_Value = value;
                    RaisePropertyChanged(() => Value);
                }
            }
        }

        private string m_FileValue;
        public string FileValue
        {
            get { return m_FileValue; }
            set
            {
                if (m_FileValue != value)
                {
                    m_FileValue = value;
                    RaisePropertyChanged(() => FileValue);
                }
            }
        }

        private double? m_UpDown;
        public double? UpDown
        {
            get { return m_UpDown; }
            set
            {
                if (m_UpDown != value)
                {
                    m_UpDown = value;
                    RaisePropertyChanged(() => UpDown);
                }
            }
        }

        //public double? UpDown
        //{
        //    get {
        //        if (Value != null && FileValue != null)
        //            return double.Parse(Value) - double.Parse(FileValue);
        //        else
        //            return null;
        //    }
        //}


        private bool m_PmcType;
        public bool PmcType
        {
            get { return m_PmcType; }
            set
            {
                if (m_PmcType != value)
                {
                    m_PmcType = value;
                    RaisePropertyChanged(() => PmcType);
                }
            }
        }

        private PmcBomItemRecipesDto pmcBomItem = new PmcBomItemRecipesDto();

        public PmcBomItemRecipesDto PmcBomItem
        {
            get { return pmcBomItem; }
            set
            {
                if (pmcBomItem != value)
                {
                    pmcBomItem = value;
                    RaisePropertyChanged(() => PmcBomItem);
                }
            }
        }

        private bool m_MacroType;
        public bool MacroType
        {
            get { return m_MacroType; }
            set
            {
                if (m_MacroType != value)
                {
                    m_MacroType = value;
                    RaisePropertyChanged(() => MacroType);
                }
            }
        }

        private MacroBomItemRecipesDto macroBomItem = new MacroBomItemRecipesDto();

        public MacroBomItemRecipesDto MacroBomItem
        {
            get { return macroBomItem; }
            set
            {
                if (macroBomItem != value)
                {
                    macroBomItem = value;
                    RaisePropertyChanged(() => MacroBomItem);
                }
            }
        }
    }
}

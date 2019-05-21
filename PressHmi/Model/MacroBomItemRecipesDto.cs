using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class MacroBomItemRecipesDto : ViewModelBase
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

        private short m_Adr;
        public short Adr
        {
            get { return m_Adr; }
            set
            {
                if (m_Adr != value)
                {
                    m_Adr = value;
                    RaisePropertyChanged(() => Adr);
                }
            }
        }

        private bool? m_IsRecipes;
        public bool? IsRecipes
        {
            get { return m_IsRecipes; }
            set
            {
                if (m_IsRecipes != value)
                {
                    m_IsRecipes = value;
                    RaisePropertyChanged(() => IsRecipes);
                }
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
    }
}

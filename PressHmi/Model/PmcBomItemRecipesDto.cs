using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using FanucCnc.Enum;

namespace PressHmi.Model
{
    public class PmcBomItemRecipesDto : ViewModelBase
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

        private PmcAdrTypeEnum m_AdrType;
        public PmcAdrTypeEnum AdrType
        {
            get { return m_AdrType; }
            set
            {
                if (m_AdrType != value)
                {
                    m_AdrType = value;
                    RaisePropertyChanged(() => AdrType);
                }
            }
        }

        private PmcDataTypeEnum m_DataType;
        public PmcDataTypeEnum DataType
        {
            get { return m_DataType; }
            set
            {
                if (m_DataType != value)
                {
                    m_DataType = value;
                    RaisePropertyChanged(() => DataType);
                }
            }
        }

        private ushort m_Adr;
        public ushort Adr
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

        private ushort m_Bit;
        public ushort Bit
        {
            get { return m_Bit; }
            set
            {
                if (m_Bit != value)
                {
                    m_Bit = value;
                    RaisePropertyChanged(() => Bit);
                }
            }
        }


        private double? m_ConversionFactor;
        public double? ConversionFactor
        {
            get { return m_ConversionFactor; }
            set
            {
                if (m_ConversionFactor != value)
                {
                    m_ConversionFactor = value;
                    RaisePropertyChanged(() => ConversionFactor);
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

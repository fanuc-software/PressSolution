using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanucCnc.Enum;

namespace FanucCnc.Model
{
    public class PmcBomItem
    {
        public string Id { get; set; }

        public PmcAdrTypeEnum AdrType { get; set; }

        public PmcDataTypeEnum DataType { get; set; }

        public ushort Adr { get; set; }

        public ushort Bit { get; set; }

        public double? ConversionFactor { get; set; }

        public bool? IsRecipes { get; set; }
    }
}

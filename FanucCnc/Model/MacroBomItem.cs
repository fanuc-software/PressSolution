using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class MacroBomItem
    {
        public string Id { get; set; }

        public short Adr { get; set; }

        public bool? IsRecipes { get; set; }
    }
}

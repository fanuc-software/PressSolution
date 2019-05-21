using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class MacroBomItemRecipes
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public short Adr { get; set; }

        public bool? IsRecipes { get; set; }

        public string Value { get; set; }
    }
}

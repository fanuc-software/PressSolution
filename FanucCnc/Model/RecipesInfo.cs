using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class RecipesInfo
    {
        private List<PmcBomItemRecipes> pmcBoms = new List<PmcBomItemRecipes>();

        public List<PmcBomItemRecipes> PmcBoms
        {
            set
            {
                pmcBoms = value;
            }
            get
            {
                return pmcBoms;
            }
        }

        private List<MacroBomItemRecipes> macroBoms = new List<MacroBomItemRecipes>();

        public List<MacroBomItemRecipes> MacroBoms
        {
            set
            {
                macroBoms = value;
            }
            get
            {
                return macroBoms;
            }
        }
    }
}

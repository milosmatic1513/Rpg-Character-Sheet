using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    [Serializable]
    public class HomebrewItem
    {
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string DmgType { get; set; }
        public string DmgDice { get; set; }
        public string Description { get; set; }
        public string Ac { get; set; }
        public HomebrewItem()
        {
            Name = "";
            Rarity = "";
            DmgType = "";
            DmgDice = "";
            Description = "";
            Ac = "";
        }
        public HomebrewItem(string na, string ra, string dT, string dD, string des, string a)
        {
            Name = na;
            Rarity = ra;
            DmgType = dT;
            DmgDice = dD;
            Description = des;
            Ac = a;
        }
    }
}

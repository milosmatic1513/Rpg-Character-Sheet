using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    [Serializable]
     public class Spell_class
    {
        public string name, duration, description, casting_time, components, range, clas, lvl, sch;
        public Spell_class(string name_temp, string time_temp, string comps_temp, string duration_temp, string desc_temp,string range_temp, string class_temp, string level_temp, string school_temp)
        {
            
            name = name_temp;
            casting_time = time_temp;
            components = comps_temp;
            duration = duration_temp;
            description = desc_temp;
            range = range_temp;
            clas = class_temp;
            lvl = level_temp;
            sch = school_temp;
        }
    }
}

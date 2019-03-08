using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class spell : UserControl
    {
        string name, cast, dur, comp, desc, range, clas, lvl, sch;
        Spell_creation sp_create;

        Spells parentForm;
        int positionInList;

        private void remove_Click(object sender, EventArgs e)
        {
            ((cha_save)parentForm.getParent()).deleteSpell(positionInList);
            parentForm.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(desc,"Description");
        }

        private void Clicked()
        {
            string s =
              "Name : "
            + name
             + "\n\nClasses :  "
              + clas
              + "\n\nSchool : "
              + sch
              + "\n\nLevel : "
              + lvl
              + "\n\nCasting : "
              + cast
              + "\n\nRange : "
             + range
              + "\n\nComponents : "
              + comp
              + "\n\nDuration : "
             + dur
              + "\n\nDescription :\n"
              + desc;
            MessageBox.Show(s);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            sp_create = new Spell_creation(s_name.Text, c_time.Text, s_dur.Text, s_comps.Text, desc, rng.Text, clas, lvl, sch);
            sp_create.ShowDialog();
            if (sp_create.c1)
            {
                name = sp_create.spell_name;
                cast = sp_create.casting_time;
                comp = sp_create.comps;
                dur = sp_create.duration;
                desc = sp_create.desc;
                range = sp_create.range;
                clas = sp_create.clas;
                lvl = sp_create.level;
                sch = sp_create.sch;
                update();
            }
        }

        public spell(string name_temp,string time_temp,string comps_temp, string duration_temp,string desc_temp, string range_temp, string class_temp, string level_temp, string school_temp, int i, Spells parent)
        {
            InitializeComponent();
            name = name_temp;
            cast = time_temp;
            comp = comps_temp;
            dur = duration_temp;
            desc = desc_temp;
            range = range_temp;
            clas = class_temp;
            lvl = level_temp;
            sch = school_temp;

            positionInList = i;
            parentForm = parent;
            update();

            foreach (Control s in this.Controls)
            {
                if (s.GetType().Equals(typeof(TextBox)))
                {
                    TextBox x = (TextBox)s;
                    x.Click += new EventHandler((sender, e) => Clicked());
                }
            }
            this.Click += new EventHandler((sender, e) => Clicked());
        }

        private void update()
        {
            s_name.Text = name;
            c_time.Text = cast;
            s_comps.Text = comp;
            s_dur.Text = dur;
            rng.Text = range;
        }
    }
}

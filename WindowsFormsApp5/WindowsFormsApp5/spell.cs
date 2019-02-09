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

        string name,time,comps, duration, desc,range;
        Spell_creation sp_create;
        Spells parentForm;

        private void remove_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            sp_create = new Spell_creation(s_name.Text,c_time.Text,s_dur.Text,s_comps.Text,desc,rng.Text);
            sp_create.ShowDialog();
            name = sp_create.spell_name;
            time = sp_create.casting_time;
            comps = sp_create.comps;
            duration = sp_create.duration;
            desc = sp_create.desc;
            range = sp_create.range;
            update();
        }

        private void spell_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this, desc);

        }

        public spell(string name_temp,string time_temp,string comps_temp, string duration_temp,string desc_temp, string range_temp)
        {
            InitializeComponent();
            name = name_temp;
            time = time_temp;
            comps = comps_temp;
            duration = duration_temp;
            desc = desc_temp;
            range = range_temp;
        }
        private void update()
        {
            s_name.Text = name;
            c_time.Text = time;
            s_comps.Text = comps;
            s_dur.Text = duration;
            rng.Text = range;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this, desc);
        }


        private void spell_Load(object sender, EventArgs e)
        {
            s_name.Text = name;
            c_time.Text = time;
            s_comps.Text = comps;
            s_dur.Text = duration;
            rng.Text = range;
            parentForm =(Spells) this.FindForm();
        }
    }
}

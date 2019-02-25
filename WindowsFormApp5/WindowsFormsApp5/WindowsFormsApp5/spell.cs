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
        RichTextBox description = new RichTextBox();
        string name,time,comps, duration, desc,range;
        Spell_creation sp_create;
        Spells parentForm;
        ToolTip t_name, t_castTime, t_comps, t_dur, t_ran;
        Size original_size;



        int positionInList;

        private void remove_Click(object sender, EventArgs e)
        {
            DialogResult temp =  MessageBox.Show("Are you sure you want to delete " + name,"Delete spell",MessageBoxButtons.YesNo);
            if (temp.Equals(DialogResult.Yes))
            {
                ((cha_save)parentForm.getParent()).deleteSpell(positionInList);
                parentForm.Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox temp = (CheckBox)sender;
            if (temp.Checked)
            {
                
                description.Text = desc;
                description.Size = new Size(this.Size.Width - 40, 100);
                description.Location = new Point(20, this.Height);
                this.Controls.Add(description);
                this.Size = new Size(this.Width, this.Height + description.Height + 20);
            }
            else
            {
                this.Size = original_size;
            }
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

        public spell(string name_temp,string time_temp,string comps_temp, string duration_temp,string desc_temp, string range_temp, int i)
        {
            InitializeComponent();
            name = name_temp;
            time = time_temp;
            comps = comps_temp;
            duration = duration_temp;
            desc = desc_temp;
            range = range_temp;
            positionInList = i;
        }
        private void update()
        {
            s_name.Text = name;
            c_time.Text = time;
            s_comps.Text = comps;
            s_dur.Text = duration;
            rng.Text = range;
        }


        private void spell_Load(object sender, EventArgs e)
        {
            original_size = this.Size;
            s_name.Text = name;
            c_time.Text = time;
            s_comps.Text = comps;
            s_dur.Text = duration;
            rng.Text = range;
            parentForm =(Spells) this.FindForm();

            t_name = new ToolTip();
            t_castTime = new ToolTip();
            t_comps = new ToolTip();
            t_dur = new ToolTip();
            t_ran = new ToolTip();
            t_name.SetToolTip(s_name, name);
            t_castTime.SetToolTip(c_time, time);
            t_comps.SetToolTip(s_comps, comps);
            t_dur.SetToolTip(s_dur, duration);
            t_ran.SetToolTip(rng, range);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    

    public partial class Spell_creation : Form
    {
        public string spell_name, casting_time, duration, comps, desc, range, clas, level, sch;
        public bool c1, ch1, ch2, ch3;
        cha_save parentForm;

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ch3 = !ch3;
            checkBox1.BackColor = Color.White;
            checkBox2.BackColor = Color.White;
            checkBox3.BackColor = Color.White;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ch2 = !ch2;
            checkBox1.BackColor = Color.White;
            checkBox2.BackColor = Color.White;
            checkBox3.BackColor = Color.White;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ch1 = !ch1;
            checkBox1.BackColor = Color.White;
            checkBox2.BackColor = Color.White;
            checkBox3.BackColor = Color.White;
        }

        private string FixNameFormat(string value) //Each word starts with Caps
        {
            char[] array = value.ToCharArray();
            array[0] = char.ToUpper(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            return new string(array);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            c1 = false;
            ch1 = false;
            ch2 = false;
            ch3 = false;
            this.Close();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Control s in this.Controls)
            {
                Control x = new Control();
                if (s.GetType().Equals(typeof(TextBox))) x = (TextBox)s;
                else if (s.GetType().Equals(typeof(RichTextBox))) x = (RichTextBox)s;
                else if (s.GetType().Equals(typeof(ComboBox))) x = (ComboBox)s;
                Type ofx = x.GetType();
                if (x.Text == "" && (ofx == typeof(TextBox) || ofx == typeof(RichTextBox) || ofx == typeof(ComboBox)))
                {
                    c1 = false;
                    break;
                }
                else c1 = true;
            }
            if (sender != null)
            {
                Control y = new Control();
                if (sender.GetType().Equals(typeof(TextBox))) y = (TextBox)sender;
                else if (sender.GetType().Equals(typeof(RichTextBox))) y = (RichTextBox)sender;
                else if (sender.GetType().Equals(typeof(ComboBox))) y = (ComboBox)sender;
                y.BackColor = Color.White;
            }
        }

        public Spell_creation(cha_save p)
        {
            InitializeComponent();
            parentForm = p;
        }

        public Spell_creation(string spell_name1,string casting_time1,string duration1,string comps1,string desc1,string range1,string clas1,string level1,string sch1)
        {
            InitializeComponent();
            ch1 = false;
            ch2 = false;
            ch3 = false;

            name.Text = spell_name1;
            casting.Text = casting_time1;
            if (comps1.Contains("V")) checkBox1.Checked = true;
            if (comps1.Contains("S")) checkBox2.Checked = true;
            if (comps1.Contains("M")) checkBox3.Checked = true;
            dur.Text = duration1;
            descr.Text = desc1;
            range_box.Text = range1;
            classSearch.Text = clas1;
            levelSearch.Text = level1;
            school.Text = sch1;

            spell_name = spell_name1;
            casting_time = casting_time1;
            duration = duration1;
            comps = comps1;
            desc = desc1;
            range = range1;
            clas = clas1;
            level = level1;
            sch = sch1;

            c1 = false;
            textBox1_TextChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c1 && (ch1 || ch2 || ch3))
            {
                spell_name = name.Text;
                casting_time = casting.Text;
                duration = dur.Text;
                string checks = "";
                foreach (Control s in panel1.Controls)
                {
                    CheckBox x = (CheckBox)s;
                    if (x.Checked) checks += x.Text + " ";
                }
                comps = checks;
                desc = descr.Text;
                range = range_box.Text;
                clas = classSearch.Text;
                level = levelSearch.Text;
                sch = school.Text;
                bool unique = true;
                foreach (Spell_class s in parentForm.getSpells())
                {
                    if (s.name.ToLower() == spell_name.ToLower())
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    spell_name = FixNameFormat(spell_name);
                    this.Close();
                }
                else MessageBox.Show("Spell Name already exists");
            }
            else
            {
                foreach (Control s in this.Controls)
                {
                    Control x = new Control();
                    if (s.GetType().Equals(typeof(TextBox))) x = (TextBox)s;
                    else if (s.GetType().Equals(typeof(RichTextBox))) x = (RichTextBox)s;
                    else if (s.GetType().Equals(typeof(ComboBox))) x = (ComboBox)s;
                    if (x.Text == "") x.BackColor = Color.Pink;
                }
                bool noChecks = true;
                foreach (Control s in panel1.Controls)
                {
                    CheckBox x = (CheckBox)s;
                    if (x.Checked)
                    {
                        noChecks = false;
                        break;
                    }
                }
                if (noChecks)
                {
                    checkBox1.BackColor = Color.Pink;
                    checkBox2.BackColor = Color.Pink;
                    checkBox3.BackColor = Color.Pink;
                }
            }
        }
    }
}

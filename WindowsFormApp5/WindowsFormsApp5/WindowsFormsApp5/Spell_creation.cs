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
        public string spell_name, casting_time, duration,comps,desc,range;
        public bool c1, c2, c3, c4, c5;

        private void range_box_TextChanged(object sender, EventArgs e)
        {
            if (range_box.Text != null) c5 = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != null) c4 = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null) c2 = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null) c1 = true;
        }

        private void Spell_creation_Load(object sender, EventArgs e)
        {

        }

        public Spell_creation()
        {
            InitializeComponent();
        }
        public Spell_creation(string spell_name1,string casting_time1,string duration1,string comps1,string desc1,string range1)
        {
            InitializeComponent();
            textBox1.Text=spell_name1;
            textBox2.Text=casting_time1;
            textBox3.Text = duration1;
            textBox4.Text = comps1;
            richTextBox1.Text = desc1;
            range_box.Text = range1;

            spell_name = spell_name1;
            casting_time = casting_time1;
            duration = duration1;
            comps = comps1;
            desc = desc1;
            range = range1;

            c1 = false;
            c2 = false;
            c3 = false;
            c4 = false;
            c5 = false;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null) c3 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spell_name = textBox1.Text;
            casting_time = textBox2.Text;
            duration = textBox3.Text;
            comps = textBox4.Text;
            desc = richTextBox1.Text;
            range = range_box.Text;
            this.Close();
        }
    }
}

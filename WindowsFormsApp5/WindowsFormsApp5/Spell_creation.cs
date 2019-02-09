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
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

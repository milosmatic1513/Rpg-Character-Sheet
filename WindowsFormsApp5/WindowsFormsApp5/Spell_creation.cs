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
        public Spell_creation(string spell_name,string casting_time,string duration,string comps,string desc,string range)
        {
            InitializeComponent();
            textBox1.Text=spell_name;
            textBox2.Text=casting_time;
            textBox3.Text = duration;
            textBox4.Text = comps;
            richTextBox1.Text = desc;
            range_box.Text = range;
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

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
    public partial class HomebrewItemCreation : Form
    {
        public bool done;
        public HomebrewItem homeB;

        public HomebrewItemCreation()
        {
            InitializeComponent();
            done = false;
            homeB = new HomebrewItem();
            add.Text = "Add Item";
        }

        public HomebrewItemCreation(string n,string r,string dT,string dD,string desc,string a)
        {
            InitializeComponent();
            done = false;
            homeB = new HomebrewItem();
            add.Text = "Edit Item";
            name.Text = n;
            rarity.Text = r;
            dmgType.Text = dT;
            dmgDice.Text = dD;
            description.Text = desc;
            ac.Text = a;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && rarity.Text != "" && description.Text != "")
            {
                homeB = new HomebrewItem(name.Text, rarity.Text, dmgType.Text, dmgDice.Text, description.Text, ac.Text);
                done = true;
                this.Close();
            }
            else
            {
                if (name.Text == "") name.BackColor = Color.Pink;
                if (rarity.Text == "") rarity.BackColor = Color.Pink;
                if (description.Text == "") description.BackColor = Color.Pink;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            RichTextBox t = (RichTextBox)sender;
            t.BackColor = Color.White;
        }
    }
}

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
        cha_save parentForm;
        public bool done;

        public HomebrewItemCreation(cha_save p)
        {
            InitializeComponent();
            parentForm = p;
            done = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && rarity.Text != "" && description.Text != "")
            {
                HomebrewItem hm = new HomebrewItem(name.Text, rarity.Text, dmgType.Text, dmgDice.Text, description.Text);
                parentForm.addHomebrew(hm);
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

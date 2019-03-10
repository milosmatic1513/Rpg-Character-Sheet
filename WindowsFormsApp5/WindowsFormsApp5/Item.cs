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
    public partial class Item : UserControl
    {
        string name, rarity, dmgType, dmgDice, desc, ac;
        cha_save mainForm;
        HomebrewItemsDisplay parentForm;
        int index;

        private void button2_Click(object sender, EventArgs e)
        {
            HomebrewItemCreation hmc = new HomebrewItemCreation(name, rarity, dmgType, dmgDice, desc, ac);
            hmc.ShowDialog();
            if (hmc.done)
            {
                mainForm.updateHomebrew(hmc.homeB, index);
                parentForm.UpdatePanel();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.DeleteItem(index);
        }

        private void Clicked()
        {
            string s = "Name : " + name + "\n\nRarity : " + rarity + "\n\nArmor Class : " + ac + "\n\nDamage Type : " + dmgType + "\n\nDamage Dice : " + dmgDice + "\n\nDescription :\n" + desc;
            MessageBox.Show(s);
        }

        public Item(string n, string ra, string dT, string dD, string d, string a, HomebrewItemsDisplay p, int i)
        {
            InitializeComponent();
            name = n;
            rarity = ra;
            dmgType = dT;
            dmgDice = dD;
            desc = d;
            ac = a;

            nameBox.Text = n;
            damageType.Text = dT;
            damageDice.Text = dD;
            armorClass.Text = a;

            parentForm = p;
            index = i;
            mainForm = p.parentForm;

            foreach (Control c in this.Controls)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t = (TextBox)c;
                    t.Click += new EventHandler((sender, e) => Clicked());
                }
            }
            this.Click += new EventHandler((sender, e) => Clicked());
        }
    }
}

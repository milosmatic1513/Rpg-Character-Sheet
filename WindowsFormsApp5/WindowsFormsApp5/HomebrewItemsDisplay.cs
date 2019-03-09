﻿using System;
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
    public partial class HomebrewItemsDisplay : Form
    {
        cha_save parentForm;

        public HomebrewItemsDisplay(cha_save p)
        {
            InitializeComponent();
            parentForm = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomebrewItemCreation hmc = new HomebrewItemCreation(parentForm);
            hmc.ShowDialog();
            if (hmc.done)
            {
                UpdatePanel();
            }
        }

        public void DeleteItem(int i)
        {
            parentForm.deleteHomebrew(i);
            UpdatePanel();
        }

        private void UpdatePanel()
        {
            flowLayoutPanel1.Controls.Clear();
            int i = 0;
            foreach (HomebrewItem hm in parentForm.getHomebrewItems())
            {
                Item it = new Item(hm.Name, hm.Rarity, hm.DmgType, hm.DmgDice, hm.Description, this, i);
                flowLayoutPanel1.Controls.Add(it);
                i++;
            }
        }
    }
}

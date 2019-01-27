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
    public partial class cha_save : Form
    {
        Player player;
        private class Player
        {
            public int[] abbility_scores= {0,0,0,0,0,0};
            public int[] abbility_moddifiers = { 0, 0, 0, 0, 0, 0 };
            public int prof = 0;
            public int ac = 0;
            public void add_score(int score_addition,int score_number)
            {
                if (abbility_scores[score_number] < 20)
                {
                    abbility_scores[score_number] += score_addition;
                    abbility_moddifiers[score_number] = (abbility_scores[score_number] % 10) / 2 + (abbility_scores[score_number] / 10 - 1) * 5;
                }
            }
            public void update_score(Label abbility,Label moddifier,int score)
            {
                abbility.Text = abbility_scores[score].ToString();
                if (abbility_moddifiers[score]>=0) moddifier.Text ="+"+ abbility_moddifiers[score].ToString();
                else moddifier.Text = abbility_moddifiers[score].ToString();
            }
            public void update_general(Label target , int score)
            {
                target.Text = "+" + score.ToString();
            }
        }
        public cha_save()
        {
            InitializeComponent();
            player = new Player();

        }

        private void str_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 0);
            player.update_score(str_lbl, str_mod_lbl, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dex_button_Click(object sender, EventArgs e)
        {
            player.add_score(1,1);
            player.update_score(dex_lbl, dex_mod_lbl, 1);
        }

        private void cons_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 2);
            player.update_score(cons_lbl, cons_mod_lbl, 2);
        }

        private void intel_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 3);
            player.update_score(intel_lbl, intel_mod_lbl, 3);
        }

        private void wis_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 4);
            player.update_score(wis_lbl, wis_mod_lbl, 4);
        }

        private void cha_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 5);
            player.update_score(cha_lbl, cha_mod_lbl, 5);
        }

        private void lvl_up(object sender, EventArgs e)
        {
            str_button.Visible = true;
            dex_button.Visible = true;
            cons_button.Visible = true;
            intel_button.Visible = true;
            wis_button.Visible = true;
            cha_button.Visible = true;
            prof_button.Visible = true;
            done.Visible = true;
        }

        private void done_Click(object sender, EventArgs e)
        {
            str_button.Visible = false;
            dex_button.Visible = false;
            cons_button.Visible = false;
            intel_button.Visible = false;
            wis_button.Visible = false;
            cha_button.Visible = false;
            prof_button.Visible = false;
            done.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void prof_button_Click(object sender, EventArgs e)
        {
            player.prof += 1;
            player.update_general(prof_lbl, player.prof);
        }

        private void str_save_CheckedChanged(object sender, EventArgs e)
        {
            if (str_save.Checked)
            {
                str_save_mod.Visible = true;
                str_save_mod.Text = "+" + (player.abbility_moddifiers[0] + player.prof);
            }
            else
            {
                str_save_mod.Visible = false;
            }
        }
        private void dex_save_CheckedChanged(object sender, EventArgs e)
        {
            if (dex_save.Checked)
            {
                dex_save_mod.Visible = true;
                dex_save_mod.Text = "+" + (player.abbility_moddifiers[1] + player.prof);
            }
            else
            {
                dex_save_mod.Visible = false;
            }
        }

        private void cons_save_CheckedChanged(object sender, EventArgs e)
        {
            if (cons_save.Checked)
            {
                cons_save_mod.Visible = true;
                cons_save_mod.Text = "+" + (player.abbility_moddifiers[2] + player.prof);
            }
            else
            {
                cons_save_mod.Visible = false;
            }
        }

        private void wis_save_CheckedChanged(object sender, EventArgs e)
        {
            if (wis_save.Checked)
            {
                wis_save_mod.Visible = true;
                wis_save_mod.Text = "+" + (player.abbility_moddifiers[3] + player.prof);
            }
            else
            {
                wis_save_mod.Visible = false;
            }
        }

        private void cha_save_CheckedChanged(object sender, EventArgs e)
        {
            if (chaa_save.Checked)
            {
                cha_save_mod.Visible = true;
                cha_save_mod.Text = "+" + (player.abbility_moddifiers[4] + player.prof);
            }
            else
            {
                cha_save_mod.Visible = false;
            }
        }

        private void intel_save_CheckedChanged(object sender, EventArgs e)
        {
            if (intel_save.Checked)
            {
                intel_save_mod.Visible = true;
                intel_save_mod.Text = "+" + (player.abbility_moddifiers[5] + player.prof);
            }
            else
            {
                intel_save_mod.Visible = false;
            }
        }
    }
}

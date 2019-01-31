using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp5
{
    public partial class cha_save : Form
    {
        Player player;
        public void update_all()
        {
            player.update_score(str_lbl, str_mod_lbl, "strength");
            player.update_score(dex_lbl, dex_mod_lbl, "dexterity");
            player.update_score(cons_lbl, cons_mod_lbl, "constitution");
            player.update_score(intel_lbl, intel_mod_lbl, "inteligence");
            player.update_score(wis_lbl, wis_mod_lbl, "wisdom");
            player.update_score(cha_lbl, cha_mod_lbl, "charisma");

        }
        private class Player
        {
            public int[] abbility_scores = { 0, 0, 0, 0, 0, 0 };
            public int[] abbility_moddifiers = { 0, 0, 0, 0, 0, 0 };

            public   Hashtable player_stats = new Hashtable();





            public int prof = 0;
            public int ac = 0;
            public int hp = 0;
            public Player()
            {
                //arxikopoisi pinaka metavlitwn 
                player_stats.Add("strength", 0);
                player_stats.Add("dexterity", 0);
                player_stats.Add("constitution", 0);
                player_stats.Add("inteligence", 0);
                player_stats.Add("wisdom", 0);
                player_stats.Add("charisma", 0);
                player_stats.Add("ac", 0);
                player_stats.Add("profitiency", 0);
            }


            public void add_score(int score_addition,int score_number)
            {
                if (abbility_scores[score_number] < 20)
                {
                    abbility_scores[score_number] += score_addition;
                    abbility_moddifiers[score_number] = (abbility_scores[score_number] % 10) / 2 + (abbility_scores[score_number] / 10 - 1) * 5;
                }
            }
            public void update_score(Label abbility,Label moddifier,string target)
            {
                abbility.Text = player_stats[target].ToString();
                int score = (int)player_stats[target];
                int mod= (score % 10) / 2 + (score / 10 - 1) * 5;

                if (mod>=0) moddifier.Text ="+"+ mod.ToString();
                else moddifier.Text = mod.ToString();
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

        
        private void plus_minus_stat(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            if (temp.Text == "+")
            {

                int current = (int)player.player_stats[temp.Tag.ToString()];
                player.player_stats[temp.Tag.ToString()] = current + 1;


            }
            else if (temp.Text == "-")
            {
                int current =(int) player.player_stats[temp.Tag.ToString()];
                if(current>0) player.player_stats[temp.Tag.ToString()] = current - 1;

            }
            update_all();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button9.Visible = true;
            button8.Visible = true;
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
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button9.Visible = false;
            button8.Visible = false;
            done.Visible = false;
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

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void current1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown temp = (NumericUpDown)sender;
           int value = int.Parse(temp.Value.ToString());
           if(value<=progressBar1.Maximum) progressBar1.Value = value;
           if(value<=progressBar1.Maximum) progressBar1.Value = value;
           if(value<=progressBar1.Maximum) progressBar1.Value = value;
           if(value<=progressBar1.Maximum) progressBar1.Value = value;
           if(value<=progressBar1.Maximum) progressBar1.Value = value;
           if(value<=progressBar1.Maximum) progressBar1.Value = value;
        }

        private void max1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown  temp = (NumericUpDown)sender;
            progressBar1.Maximum=int.Parse(temp.Value.ToString());
        }
    }
}

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
            public AbilityScore[] abilityScores;
            public int[] ability_scores = new int[6];
            public int[] ability_modifiers = new int[6];
            public int prof = 0;
            public int ac = 0;
            public void add_score(int score_addition,int score_number)
            {
                if (ability_scores[score_number] < 20 && ability_scores[score_number] > 0)
                {
                    ability_scores[score_number] += score_addition;
                    abilityScores[score_number].Score(ability_scores[score_number]);
                    ability_modifiers[score_number] = abilityScores[score_number].GetModifier();
                }
            }
            public void update_score(Label abbility,Label moddifier,int score)
            {
                abbility.Text = ability_scores[score].ToString();
                if (ability_modifiers[score]>=0) moddifier.Text ="+"+ ability_modifiers[score].ToString();
                else moddifier.Text = ability_modifiers[score].ToString();
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
            player.abilityScores = new AbilityScore[6];
        }

        public void UpdateSavingThrows()
        {
            if (str_save.Checked) str_save_CheckedChanged(null,null);
            if (dex_save.Checked) dex_save_CheckedChanged(null,null);
            if (cons_save.Checked) cons_save_CheckedChanged(null,null);
            if (intel_save.Checked) intel_save_CheckedChanged(null,null);
            if (wis_save.Checked) wis_save_CheckedChanged(null,null);
            if (chaa_save.Checked) cha_save_CheckedChanged(null,null);
        }

        private void str_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 0);
            UpdateSavingThrows();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                player.ability_scores[i] = player.abilityScores[i].GetScore();
                player.ability_modifiers[i] = player.abilityScores[i].GetModifier();
            }
            player.prof = int.Parse(prof_lbl.Text);
        }

        private void dex_button_Click(object sender, EventArgs e)
        {
            player.add_score(1,1);
            UpdateSavingThrows();
        }

        private void cons_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 2);
            UpdateSavingThrows();
        }

        private void intel_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 3);
            UpdateSavingThrows();
        }

        private void wis_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 4);
            UpdateSavingThrows();
        }

        private void cha_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, 5);
            UpdateSavingThrows();
        }

        private void lvl_up(object sender, EventArgs e)
        {
            str_button.Visible = true;
            dex_button.Visible = true;
            cons_button.Visible = true;
            intel_button.Visible = true;
            wis_button.Visible = true;
            cha_button.Visible = true;
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
            done.Visible = false;
            label3.Text = (int.Parse(label3.Text) + 1).ToString();
            if (label3.Text == "20") button1.Enabled = false;
            prof_lbl.Text = ((int.Parse(label3.Text) + 7) / 4).ToString();
            player.prof = int.Parse(prof_lbl.Text);
            UpdateSavingThrows();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void str_save_CheckedChanged(object sender, EventArgs e)
        {
            if (str_save.Checked)
            {
                str_save_mod.Visible = true;
                str_save_mod.Text = "+" + (player.ability_modifiers[0] + player.prof);
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
                dex_save_mod.Text = "+" + (player.ability_modifiers[1] + player.prof);
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
                cons_save_mod.Text = "+" + (player.ability_modifiers[2] + player.prof);
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
                wis_save_mod.Text = "+" + (player.ability_modifiers[4] + player.prof);
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
                cha_save_mod.Text = "+" + (player.ability_modifiers[5] + player.prof);
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
                intel_save_mod.Text = "+" + (player.ability_modifiers[3] + player.prof);
            }
            else
            {
                intel_save_mod.Visible = false;
            }
        }

        private void abilityScore1_Load(object sender, EventArgs e)
        {
            abilityScore1.Ability("STRENGTH");
            player.abilityScores[0] = abilityScore1;
        }

        private void abilityScore2_Load(object sender, EventArgs e)
        {
            abilityScore2.Ability("DEXTERITY");
            player.abilityScores[1] = abilityScore2;
        }

        private void abilityScore3_Load(object sender, EventArgs e)
        {
            abilityScore3.Ability("CONSTITUTION");
            player.abilityScores[2] = abilityScore3;
        }

        private void abilityScore4_Load(object sender, EventArgs e)
        {
            abilityScore4.Ability("INTELLIGENCE");
            player.abilityScores[3] = abilityScore4;
        }

        private void abilityScore5_Load(object sender, EventArgs e)
        {
            abilityScore5.Ability("WISDOM");
            player.abilityScores[4] = abilityScore5;
        }

        private void abilityScore6_Load(object sender, EventArgs e)
        {
            abilityScore6.Ability("CHARISMA");
            player.abilityScores[5] = abilityScore6;
        }
    }
}

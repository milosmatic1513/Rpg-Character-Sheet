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
        private class Player
        {
            public AbilityScore[] abilityScores;
            public Hashtable player_stats = new Hashtable();
            public int prof = 0;
            public int ac = 0;
            public int lvlup = 0;

            public void add_score(int score_addition,string target_stat)
            {
                AbilityScore curr = (AbilityScore)player_stats[target_stat];
                curr.SetScore(curr.GetScore() + score_addition);  //Add score
                lvlup -= score_addition;
            }
        }

        public cha_save()
        {
            InitializeComponent();
            player = new Player();
            player.abilityScores = new AbilityScore[6];
        }

        public void UpdateGeneral()
        {
            if (str_save.Checked) str_save_CheckedChanged(null,null);
            if (dex_save.Checked) dex_save_CheckedChanged(null,null);
            if (cons_save.Checked) cons_save_CheckedChanged(null,null);
            if (intel_save.Checked) intel_save_CheckedChanged(null,null);
            if (wis_save.Checked) wis_save_CheckedChanged(null,null);
            if (chaa_save.Checked) cha_save_CheckedChanged(null,null);
            str_button.Visible = true;
            dex_button.Visible = true;
            cons_button.Visible = true;
            intel_button.Visible = true;
            wis_button.Visible = true;
            cha_button.Visible = true;
            str_minus.Visible = true;
            dex_minus.Visible = true;
            con_minus.Visible = true;
            int_minus.Visible = true;
            wis_minus.Visible = true;
            cha_minus.Visible = true;
            if (((AbilityScore)player.player_stats["str"]).GetScore() == 20 || player.lvlup == 0) str_button.Visible = false;
            if (((AbilityScore)player.player_stats["dex"]).GetScore() == 20 || player.lvlup == 0) dex_button.Visible = false;
            if (((AbilityScore)player.player_stats["con"]).GetScore() == 20 || player.lvlup == 0) cons_button.Visible = false;
            if (((AbilityScore)player.player_stats["int"]).GetScore() == 20 || player.lvlup == 0) intel_button.Visible = false;
            if (((AbilityScore)player.player_stats["wis"]).GetScore() == 20 || player.lvlup == 0) wis_button.Visible = false;
            if (((AbilityScore)player.player_stats["cha"]).GetScore() == 20 || player.lvlup == 0) cha_button.Visible = false;
            if (((AbilityScore)player.player_stats["str"]).GetScore() == 1 || player.lvlup == 2) str_minus.Visible = false;
            if (((AbilityScore)player.player_stats["dex"]).GetScore() == 1 || player.lvlup == 2) dex_minus.Visible = false;
            if (((AbilityScore)player.player_stats["con"]).GetScore() == 1 || player.lvlup == 2) con_minus.Visible = false;
            if (((AbilityScore)player.player_stats["int"]).GetScore() == 1 || player.lvlup == 2) int_minus.Visible = false;
            if (((AbilityScore)player.player_stats["wis"]).GetScore() == 1 || player.lvlup == 2) wis_minus.Visible = false;
            if (((AbilityScore)player.player_stats["cha"]).GetScore() == 1 || player.lvlup == 2) cha_minus.Visible = false;
        }

        private void str_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, "str");
            UpdateGeneral();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.prof = int.Parse(prof_lbl.Text);
            player.player_stats.Add("str", player.abilityScores[0]);
            player.player_stats.Add("dex", player.abilityScores[1]);
            player.player_stats.Add("con", player.abilityScores[2]);
            player.player_stats.Add("int", player.abilityScores[3]);
            player.player_stats.Add("wis", player.abilityScores[4]);
            player.player_stats.Add("cha", player.abilityScores[5]);
        }

        private void dex_button_Click(object sender, EventArgs e)
        {
            player.add_score(1,"dex");
            UpdateGeneral();
        }

        private void cons_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, "con");
            UpdateGeneral();
        }

        private void intel_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, "int");
            UpdateGeneral();
        }

        private void wis_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, "wis");
            UpdateGeneral();
        }

        private void cha_button_Click(object sender, EventArgs e)
        {
            player.add_score(1, "cha");
            UpdateGeneral();
        }

        private void lvl_up(object sender, EventArgs e)
        {
            player.lvlup = 2;
            str_button.Visible = true;
            dex_button.Visible = true;
            cons_button.Visible = true;
            intel_button.Visible = true;
            wis_button.Visible = true;
            cha_button.Visible = true;
            str_minus.Visible = true;
            dex_minus.Visible = true;
            con_minus.Visible = true;
            int_minus.Visible = true;
            wis_minus.Visible = true;
            cha_minus.Visible = true;
            done.Visible = true;
            UpdateGeneral();
        }

        private void done_Click(object sender, EventArgs e)
        {
            player.lvlup = -1;
            str_button.Visible = false;
            dex_button.Visible = false;
            cons_button.Visible = false;
            intel_button.Visible = false;
            wis_button.Visible = false;
            cha_button.Visible = false;
            str_minus.Visible = false;
            dex_minus.Visible = false;
            con_minus.Visible = false;
            int_minus.Visible = false;
            wis_minus.Visible = false;
            cha_minus.Visible = false;
            done.Visible = false;
            label3.Text = (int.Parse(label3.Text) + 1).ToString();
            if (label3.Text == "20") button1.Enabled = false;
            prof_lbl.Text = ((int.Parse(label3.Text) + 7) / 4).ToString();
            player.prof = int.Parse(prof_lbl.Text);
            UpdateGeneral();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void str_save_CheckedChanged(object sender, EventArgs e)
        {
            if (str_save.Checked)
            {
                str_save_mod.Visible = true;
                int x = ((AbilityScore)player.player_stats["str"]).GetModifier() + player.prof;
                if (x >= 0) str_save_mod.Text = "+" + x.ToString();
                else str_save_mod.Text = x.ToString();
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
                int x = ((AbilityScore)player.player_stats["dex"]).GetModifier() + player.prof;
                if (x >= 0) dex_save_mod.Text = "+" + x.ToString();
                else dex_save_mod.Text = x.ToString();
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
                int x = ((AbilityScore)player.player_stats["con"]).GetModifier() + player.prof;
                if (x >= 0) cons_save_mod.Text = "+" + x.ToString();
                else cons_save_mod.Text = x.ToString();
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
                int x = ((AbilityScore)player.player_stats["wis"]).GetModifier() + player.prof;
                if (x >= 0) wis_save_mod.Text = "+" + x.ToString();
                else wis_save_mod.Text = x.ToString();
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
                int x = ((AbilityScore)player.player_stats["cha"]).GetModifier() + player.prof;
                if (x >= 0) cha_save_mod.Text = "+" + x.ToString();
                else cha_save_mod.Text = x.ToString();
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
                int x = ((AbilityScore)player.player_stats["int"]).GetModifier() + player.prof;
                if (x >= 0) intel_save_mod.Text = "+" + x.ToString();
                else intel_save_mod.Text = x.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGeneral();
            str_button.Visible = true;
            dex_button.Visible = true;
            cons_button.Visible = true;
            intel_button.Visible = true;
            wis_button.Visible = true;
            cha_button.Visible = true;
            str_minus.Visible = true;
            dex_minus.Visible = true;
            con_minus.Visible = true;
            int_minus.Visible = true;
            wis_minus.Visible = true;
            cha_minus.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.lvlup = -1;
            str_button.Visible = false;
            dex_button.Visible = false;
            cons_button.Visible = false;
            intel_button.Visible = false;
            wis_button.Visible = false;
            cha_button.Visible = false;
            str_minus.Visible = false;
            dex_minus.Visible = false;
            con_minus.Visible = false;
            int_minus.Visible = false;
            wis_minus.Visible = false;
            cha_minus.Visible = false;
            button4.Visible = false;
            UpdateGeneral();
        }

        private void str_minus_Click(object sender, EventArgs e)
        {
            player.add_score(-1, "str");
            UpdateGeneral();
        }

        private void dex_minus_Click(object sender, EventArgs e)
        {
            player.add_score(-1, "dex");
            UpdateGeneral();
        }

        private void con_minus_Click(object sender, EventArgs e)
        {
            player.add_score(-1, "con");
            UpdateGeneral();
        }

        private void int_minus_Click(object sender, EventArgs e)
        {
            player.add_score(-1, "int");
            UpdateGeneral();
        }

        private void wis_minus_Click(object sender, EventArgs e)
        {
            player.add_score(-1, "wis");
            UpdateGeneral();
        }

        private void cha_minus_Click(object sender, EventArgs e)
        {
            player.add_score(-1, "cha");
            UpdateGeneral();
        }
    }
}

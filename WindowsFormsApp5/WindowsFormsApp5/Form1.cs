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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Collections;
namespace WindowsFormsApp5
{
    public partial class cha_save : Form
    { 
        Hashtable checks;
        Player player;
        AbilityScore[] abilityScores;
        BinaryFormatter formater;
        bool editOrLvl; //True = edit , False = Lvlup


        public void hide_all()
        {
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
        }


        [Serializable]
        private class Player
        {
            public Hashtable player_stats = new Hashtable();
            public Hashtable nameToIndex = new Hashtable()
            {
                { "str" , 0 },
                { "dex" , 1 },
                { "con" , 2 },
                { "int" , 3 },
                { "wis" , 4 },
                { "cha" , 5 }
            };
            public int prof = 0;
            public int ac = 0;
            public int lvlup = 0;
            public string name;
            public int level = 1;
            public string p_class;
            public int[] changeOnLvlUp = new int[6];

            public void add_score(int score_addition, string target_stat)
            {
                AbilityScore curr = (AbilityScore)player_stats[target_stat];
                curr.SetScore(curr.GetScore() + score_addition);  //Add score
                changeOnLvlUp[(int)nameToIndex[target_stat]] += score_addition;
                lvlup -= score_addition;
            }
        }



        public cha_save()
        {
            InitializeComponent();
            player = new Player();
            abilityScores = new AbilityScore[6];
            formater = new BinaryFormatter();
            foreach (int x in player.changeOnLvlUp) { player.changeOnLvlUp[x] = 0; }
            editOrLvl = false;
        }

        public void UpdateGeneral()
        {
            if (str_save.Checked) saving_check(str_save);
            if (dex_save.Checked) saving_check(dex_save);
            if (con_save.Checked) saving_check(con_save);
            if (intel_save.Checked) saving_check(intel_save);
            if (wis_save.Checked) saving_check(wis_save); 
            if (chaa_save.Checked) saving_check(chaa_save);

            if (((AbilityScore)player.player_stats["str"]).GetScore() == 20 || player.changeOnLvlUp[0] == 2 || player.lvlup == 0) str_button.Visible = false;
            else str_button.Visible = true;

            if (((AbilityScore)player.player_stats["dex"]).GetScore() == 20 || player.changeOnLvlUp[1] == 2 || player.lvlup == 0) dex_button.Visible = false;
            else dex_button.Visible = true;

            if (((AbilityScore)player.player_stats["con"]).GetScore() == 20 || player.changeOnLvlUp[2] == 2 || player.lvlup == 0) cons_button.Visible = false;
            else cons_button.Visible = true;

            if (((AbilityScore)player.player_stats["int"]).GetScore() == 20 || player.changeOnLvlUp[3] == 2 || player.lvlup == 0) intel_button.Visible = false;
            else intel_button.Visible = true;

            if (((AbilityScore)player.player_stats["wis"]).GetScore() == 20 || player.changeOnLvlUp[4] == 2 || player.lvlup == 0) wis_button.Visible = false;
            else wis_button.Visible = true;

            if (((AbilityScore)player.player_stats["cha"]).GetScore() == 20 || player.changeOnLvlUp[5] == 2 || player.lvlup == 0) cha_button.Visible = false;
            else cha_button.Visible = true;

            if (((AbilityScore)player.player_stats["str"]).GetScore() == 1 || player.changeOnLvlUp[0] == 0 || player.lvlup == 2) str_minus.Visible = false;
            else str_minus.Visible = true;

            if (((AbilityScore)player.player_stats["dex"]).GetScore() == 1 || player.changeOnLvlUp[1] == 0 || player.lvlup == 2) dex_minus.Visible = false;
            else dex_minus.Visible = true; 

            if (((AbilityScore)player.player_stats["con"]).GetScore() == 1 || player.changeOnLvlUp[2] == 0 || player.lvlup == 2) con_minus.Visible = false;
            else con_minus.Visible = true;

            if (((AbilityScore)player.player_stats["int"]).GetScore() == 1 || player.changeOnLvlUp[3] == 0 || player.lvlup == 2) int_minus.Visible = false;
            else int_minus.Visible = true;

            if (((AbilityScore)player.player_stats["wis"]).GetScore() == 1 || player.changeOnLvlUp[4] == 0 || player.lvlup == 2) wis_minus.Visible = false;
            else wis_minus.Visible = true;

            if (((AbilityScore)player.player_stats["cha"]).GetScore() == 1 || player.changeOnLvlUp[5] == 0 || player.lvlup == 2) cha_minus.Visible = false;
            else cha_minus.Visible = true;

            level.Text = player.level.ToString();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            player.prof = int.Parse(prof_lbl.Text);
            player.player_stats.Add("str", abilityScores[0]);
            player.player_stats.Add("dex", abilityScores[1]);
            player.player_stats.Add("con", abilityScores[2]);
            player.player_stats.Add("int", abilityScores[3]);
            player.player_stats.Add("wis", abilityScores[4]);
            player.player_stats.Add("cha", abilityScores[5]);

            checks = new Hashtable()
            {
                { "str" , str_save_mod },
                { "dex" , dex_save_mod },
                { "con" , con_save_mod },
                { "int" , int_save_mod },
                { "wis" , wis_save_mod },
                { "cha" , cha_save_mod }
            };
        }

        
        private void plus_minus_stat(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            if (temp.Text == "+")
            {
                player.add_score(1, temp.Tag.ToString());
            }
            else if (temp.Text == "-")
            {
                player.add_score(-1, temp.Tag.ToString());

            }
            UpdateGeneral();
        }
        

        private void lvl_up(object sender, EventArgs e)
        {
            player.lvlup = 2;
            editOrLvl = false;
            button3.Enabled = false;
            if(player.level<=20) player.level += 1;
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
            level.Text = (int.Parse(level.Text) + 1).ToString();
            if (level.Text == "20") button1.Enabled = false;
            prof_lbl.Text = ((int.Parse(level.Text) + 7) / 4).ToString();
            player.prof = int.Parse(prof_lbl.Text);
            UpdateGeneral();
            hide_all();
            done.Visible = false;
            button1.Enabled = true;
            button3.Enabled = true;
        }

      

    
        private void saving_check(object sender, EventArgs e)
        {

            CheckBox current = (CheckBox)sender;
            Label mod = (Label)checks[current.Tag.ToString()];
            if (current.Checked)
            {
                mod.Visible = true;
                int x = ((AbilityScore)player.player_stats[current.Tag.ToString()]).GetModifier() + player.prof;
                if (x >= 0) mod.Text = "+" + x.ToString();
                else mod.Text = x.ToString();
            }
            else
            {
                mod.Visible = false;
            }
        }
        private void saving_check(object sender)
        {

            CheckBox current = (CheckBox)sender;
            Label mod = (Label)checks[current.Tag.ToString()];
            if (current.Checked)
            {
                mod.Visible = true;
                int x = ((AbilityScore)player.player_stats[current.Tag.ToString()]).GetModifier() + player.prof;
                if (x >= 0) mod.Text = "+" + x.ToString();
                else mod.Text = x.ToString();
            }
            else
            {
                mod.Visible = false;
            }
        }




        private void abilityScore1_Load(object sender, EventArgs e)
        {
            abilityScore1.Ability("STRENGTH");
            abilityScores[0] = abilityScore1;
        }

        private void abilityScore2_Load(object sender, EventArgs e)
        {
            abilityScore2.Ability("DEXTERITY");
            abilityScores[1] = abilityScore2;
        }

        private void abilityScore3_Load(object sender, EventArgs e)
        {
            abilityScore3.Ability("CONSTITUTION");
            abilityScores[2] = abilityScore3;
        }

        private void abilityScore4_Load(object sender, EventArgs e)
        {
            abilityScore4.Ability("INTELLIGENCE");
            abilityScores[3] = abilityScore4;
        }

        private void abilityScore5_Load(object sender, EventArgs e)
        {
            abilityScore5.Ability("WISDOM");
            abilityScores[4] = abilityScore5;
        }

        private void abilityScore6_Load(object sender, EventArgs e)
        {
            abilityScore6.Ability("CHARISMA");
            abilityScores[5] = abilityScore6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGeneral();
            editOrLvl = true;
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
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.lvlup = -1;
            UpdateGeneral();
            hide_all();
            button4.Visible = false;
            button1.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_box.Text))
            {
                name_box.BackColor = Color.Gray;
            }
            else
            {
                Player a = new Player();
                a = player;
                FileStream fs = new FileStream(player.name+".dat", FileMode.Create);
                formater.Serialize(fs, a);
                fs.Close();
            }
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            name_box.BackColor = Color.White;
            player.name = name_box.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.p_class = comboBox1.SelectedText.ToString();
        }
    }
}

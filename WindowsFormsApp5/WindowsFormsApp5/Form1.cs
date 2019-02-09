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

namespace WindowsFormsApp5
{


    public partial class cha_save : Form
    {
        Hashtable checks;
        Player player;
        AbilityScore[] abilityScores;
        Hashtable other_scores;
        BinaryFormatter formater;
        AbilitySkill[] abilitySkills, toolProficiencies;
        OpenFileDialog pic_open = new OpenFileDialog();
        CheckBox[] page_saving_throws;
        Spells spell_sheet;

        public int  get_mod(int x)
        {
            return (x - 10) / 2;
        }
     
        public void updateStat(string skill_to_update,bool c1,bool c2)
        {
            int index=0;
            for (int i=0; i < player.abChecks.GetLength(0);i++)
            {
                if (player.abChecks[i, 0] == skill_to_update)
                {
                    index = i;
                    break;
                }
            }
            player.abProfs[index, 0] = c1;
            player.abProfs[index, 1] = c2;
        }

        public int GetStatScore(string target)
        {
            return (int)player.player_stats[target];
        }

        public void SetStatScore(string target, int stat)
        {
            player.player_stats[target] = stat;
            UpdateGeneral();
        }

        private void hide_all()
        {
            ac_minus.Visible = false;
            ac_plus.Visible = false;
        }

        private void addAbilityChecks()
        {
            abilitySkills = new AbilitySkill[player.abChecks.GetLength(0)];
            for (int i = 0; i < player.abChecks.GetLength(0); i++)
            {
                AbilitySkill ab = new AbilitySkill();
                ab.SetAll_Skills(player.abChecks[i, 0], player.abChecks[i, 1],get_mod((int)player.player_stats[player.abChecks[i, 1]]), player.prof);
                ab.Location = new Point(5, i * 20);
                abilitySkills[i]=ab;
                skills.Controls.Add(ab);
            }
        }

        private void addTools()
        {
            string[] tools = new string[6];
            tools[0] = "Disguise Kit";
            tools[1] = "Forgery Kit";
            tools[2] = "Herbalism Kit";
            tools[3] = "Navigator's Tools";
            tools[4] = "Poisoner's Kit";
            tools[5] = "Thieves' Tools";

            for (int i = 0; i < toolProficiencies.Length; i++)
            {
                AbilitySkill ab = new AbilitySkill();
                ab.SetAll_Tools(tools[i], int.Parse(prof_lbl.Text));
                ab.Location = new Point(5, i * 20);
                toolProficiencies[i] = ab;
                toolsPanel.Controls.Add(ab);
            }
        }
        
        /*
        private void addArmors()
        {
            string[] armorName = new string[12];
            int[,] armor = new int[12, 4];
            armorName[0] = "Padded";  //Name
            armorName[1] = "Leather";
            armorName[2] = "Studded leather";
            armorName[3] = "Hide";
            armorName[4] = "Chain shirt";
            armorName[5] = "Scale mail";
            armorName[6] = "Breastplate";
            armorName[7] = "Half plate";
            armorName[8] = "Ring mail";
            armorName[9] = "Chain mail";
            armorName[10] = "Splint";
            armorName[11] = "Plate";

            armor[0, 0] = 0;  //Strength Requirement
            armor[1, 0] = 0;
            armor[2, 0] = 0;
            armor[3, 0] = 0;
            armor[4, 0] = 0;
            armor[5, 0] = 0;
            armor[6, 0] = 0;
            armor[7, 0] = 0;
            armor[8, 0] = 0;
            armor[9, 0] = 13;
            armor[10, 0] = 15;
            armor[11, 0] = 15;

            armor[0, 1] = -1;  //+Dex maximum
            armor[1, 1] = -1;
            armor[2, 1] = -1;
            armor[3, 1] = 2;
            armor[4, 1] = 2;
            armor[5, 1] = 2;
            armor[6, 1] = 2;
            armor[7, 1] = 2;
            armor[8, 1] = 0;
            armor[9, 1] = 0;
            armor[10, 1] = 0;
            armor[11, 1] = 0;

            armor[0, 2] = 11;  //Basic AC
            armor[1, 2] = 11;
            armor[2, 2] = 12;
            armor[3, 2] = 12;
            armor[4, 2] = 13;
            armor[5, 2] = 14;
            armor[6, 2] = 14;
            armor[7, 2] = 15;
            armor[8, 2] = 14;
            armor[9, 2] = 16;
            armor[10, 2] = 17;
            armor[11, 2] = 18;

            armor[0, 3] = 1;  //Disadvantage
            armor[1, 3] = 0;
            armor[2, 3] = 0;
            armor[3, 3] = 0;
            armor[4, 3] = 0;
            armor[5, 3] = 1;
            armor[6, 3] = 0;
            armor[7, 3] = 1;
            armor[8, 3] = 1;
            armor[9, 3] = 1;
            armor[10, 3] = 1;
            armor[11, 3] = 1;

            for (int i = 0; i < armorEquipment.Length; i++)
            {
                AbilitySkill ab = new AbilitySkill();
                //ab.SetAll_Armor(armorName[i], armor[i, 3], armor[i, 1], ((AbilityScore)player.player_stats["dex"]).GetModifier(), armor[i, 0], armor[i, 2], ((AbilityScore)player.player_stats["str"]).GetScore());
                ab.SetAll_Armor(armorName[i], armor[i, 3], armor[i, 1], 2, armor[i, 0], armor[i, 2], 10);
                ab.Location = new Point(5, i * 20);
                armorEquipment[i] = ab;
                armorPanel.Controls.Add(ab);
            }
        }
        */

        public void addSpell(Spell_class spell)
        {
            player.spells.Add(spell);

        }

        public List<Spell_class> getSpells()
        {
            return player.spells;
        }

        public void deleteSpell(int index)
        {
            player.spells.RemoveAt(index);
        }

        [Serializable]
        private class Player
        {
            public Hashtable player_stats = new Hashtable();

            public string[] ability_names = new string[] {"str","dex","con","int","wis","cha" };
            public Hashtable nameToIndex = new Hashtable()
            {
                { "str" , 0 },
                { "dex" , 1 },
                { "con" , 2 },
                { "int" , 3 },
                { "wis" , 4 },
                { "cha" , 5 }
            };
            public string[,] abChecks;
            public bool[,] abProfs;
            public int prof = 0;
            public int ac = 0;
            public int lvlup = 0;
            public string name="";
            public int level = 1;
            public string p_class = "";
            public Image player_image=null;
            public bool[] saving_throws=new bool[6];
            public List<Spell_class> spells=new List<Spell_class>();


            public Player()
            {
                abChecks = new string[,]
                {
                    {"Acrobatics","dex" },
                    {"Animal Handling","wis" },
                    {"Arcana","int" },
                    {"Athletics","str"},
                    {"Deception","cha"},
                    {"History","int" },
                    {"Insight","wis"},
                    {"Intimidation","cha"},
                    {"Medicine","wis" },
                    {"Nature","int" },
                    {"Perception","wis"},
                    {"Performance","cha"},
                    {"Persuasion","cha"},
                    {"Religion","int" },
                    {"Sleight of Hand","dex" },
                    {"Stealth","dex" },
                    {"Survival","wis" },
                };

                abProfs = new bool[abChecks.GetLength(0),2];


                for (int i =0; i < abProfs.GetLength(0);i++)
                {
                        abProfs[i,0] = false;
                        abProfs[i,1] = false;
                }
                for (int i = 0; i < saving_throws.Length; i++)
                {
                    saving_throws[i] = false;
                }
            }

            public int[] changeOnLvlUp = new int[6];
            public bool editOrLvl = false; //True = edit , False = Lvlup

            public void add_score(int score_addition, string target_stat)
            {
                if (target_stat == "ac")
                {
                    ac += score_addition;
                }
                else
                {
                    player_stats[target_stat] = (int)player_stats[target_stat] + score_addition;
                }
            }
        }

        public cha_save()
        {
            InitializeComponent();
            player = new Player();
            abilityScores = new AbilityScore[6];
            formater = new BinaryFormatter();
            abilitySkills = new AbilitySkill[18];
            toolProficiencies = new AbilitySkill[6];
            foreach (int x in player.changeOnLvlUp) { player.changeOnLvlUp[x] = 0; }
        }

        public void UpdateGeneral()
        {
            if (str_save.Checked) saving_check(str_save);
            if (dex_save.Checked) saving_check(dex_save);
            if (con_save.Checked) saving_check(con_save);
            if (intel_save.Checked) saving_check(intel_save);
            if (wis_save.Checked) saving_check(wis_save); 
            if (chaa_save.Checked) saving_check(chaa_save);
            
            foreach (AbilityScore ab_sc in abilityScores )
            {   
                ab_sc.SetScore((int)player.player_stats[ab_sc.Tag.ToString()]);
            }

            prof_lbl.Text=player.prof.ToString();
            level.Text = player.level.ToString();
            name_box.Text = player.name.ToString();
            class_box.Text = player.p_class.ToString();
            pictureBox1.Image=player.player_image;
            ac.Text = player.ac.ToString();


            //single and double prof
            for (int i = 0; i < abilitySkills.Length; i++)
            {
                abilitySkills[i].UpdateMod(get_mod((int)player.player_stats[player.abChecks[i, 1]]), player.prof);
                AbilitySkill temp=(AbilitySkill)abilitySkills[i];
                temp.ChangeState(player.abProfs[i, 0], player.abProfs[i, 1]);
                
            }
            for (int i = 0; i < page_saving_throws.Length; i++)
            {
                CheckBox temp=(CheckBox)page_saving_throws[i];
                temp.Checked= player.saving_throws[i];
            }
            
            for (int i = 0; i < toolProficiencies.Length; i++)
            {
                toolProficiencies[i].UpdateMod(0, int.Parse(prof_lbl.Text));
            }

            level.Text = player.level.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.prof = int.Parse(prof_lbl.Text);
            player.player_stats.Add("str", 10);
            player.player_stats.Add("dex", 10);
            player.player_stats.Add("con", 10);
            player.player_stats.Add("int", 10);
            player.player_stats.Add("wis", 10);
            player.player_stats.Add("cha", 10);

            checks = new Hashtable()
            {
                { "str" , str_save_mod },
                { "dex" , dex_save_mod },
                { "con" , con_save_mod },
                { "int" , int_save_mod },
                { "wis" , wis_save_mod },
                { "cha" , cha_save_mod }
            };

            other_scores = new Hashtable()
            {
                { "name" ,name_box },
                { "class" ,class_box},
                {"level", level },
                {"prof",prof_lbl },
                {"ac",prof_lbl }
            };
            page_saving_throws = new CheckBox[] { str_save, dex_save, con_save, intel_save, wis_save, chaa_save };

            saveFileDialog1.Filter = "Character Files|*.dat";
            openFileDialog1.Filter = "Character Files|*.dat|All files|*.*";
            pic_open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            addAbilityChecks();
            addTools();
            
            str.Set_Stats("str");
            str.Set_Parent(this);
            dex.Set_Stats("dex");
            dex.Set_Parent(this);
            con.Set_Stats("con");
            con.Set_Parent(this);
            inte.Set_Stats("int");
            inte.Set_Parent(this);
            wis.Set_Stats("wis");
            wis.Set_Parent(this);
            cha.Set_Stats("cha");
            cha.Set_Parent(this);
            str.Visible = false;
            dex.Visible = false;
            con.Visible = false;
            inte.Visible = false;
            wis.Visible = false;
            cha.Visible = false;
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
            player.editOrLvl = false;
            button3.Enabled = false;
            if(player.level<=20) player.level += 1;
            done_Click(sender, e);
            UpdateGeneral();
        }

        private void done_Click(object sender, EventArgs e)
        {
            player.lvlup = -1;
            level.Text = (int.Parse(level.Text) + 1).ToString();
            prof_lbl.Text = ((int.Parse(level.Text) + 6) / 4).ToString();
            player.prof = int.Parse(prof_lbl.Text);
            UpdateGeneral();
            hide_all();
            button1.Enabled = true;
            if (level.Text == "20") button1.Enabled = false;
            button3.Enabled = true;
            foreach (int x in player.changeOnLvlUp) { player.changeOnLvlUp[x] = 0; }
        }

        private void saving_check(object sender, EventArgs e)
        {

            CheckBox current = (CheckBox)sender;
            Label mod = (Label)checks[current.Tag.ToString()];
            AbilityScore ability = (AbilityScore)abilityScores[(int)player.nameToIndex[current.Tag.ToString()]];
            int original_mod = ability.GetModifier();
            if (current.Checked)
            {
                mod.Visible = true;
                int x = original_mod + player.prof;
                if (x >= 0) mod.Text = "+" + x.ToString();
                else mod.Text = x.ToString();
            }
            else
            {
                mod.Visible = false;
            }
            player.saving_throws[(int)player.nameToIndex[current.Tag]]= current.Checked;
        }
        private void saving_check(object sender)
        {

            CheckBox current = (CheckBox)sender;
            Label mod = (Label)checks[current.Tag.ToString()];
            AbilityScore ability = (AbilityScore)abilityScores[(int)player.nameToIndex[current.Tag.ToString()]];
            int original_mod = ability.GetModifier();
            if (current.Checked)
            {
                mod.Visible = true;
                int x = original_mod + player.prof;
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
            abilityScore1.Tag = "str";
        }

        private void abilityScore2_Load(object sender, EventArgs e)
        {
            abilityScore2.Ability("DEXTERITY");
            abilityScores[1] = abilityScore2;
            abilityScore2.Tag = "dex";
        }

        private void abilityScore3_Load(object sender, EventArgs e)
        {
            abilityScore3.Ability("CONSTITUTION");
            abilityScores[2] = abilityScore3;
            abilityScore3.Tag = "con";
        }

        private void abilityScore4_Load(object sender, EventArgs e)
        {
            abilityScore4.Ability("INTELLIGENCE");
            abilityScores[3] = abilityScore4;
            abilityScore4.Tag = "int";
        }

        private void abilityScore5_Load(object sender, EventArgs e)
        {
            abilityScore5.Ability("WISDOM");
            abilityScores[4] = abilityScore5;
            abilityScore5.Tag = "wis";
        }

        private void abilityScore6_Load(object sender, EventArgs e)
        {
            abilityScore6.Ability("CHARISMA");
            abilityScores[5] = abilityScore6;
            abilityScore6.Tag = "cha";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGeneral();
            player.editOrLvl = true;
            button4.Visible = true;
            button1.Enabled = false;
            ac_minus.Visible = true;
            ac_plus.Visible = true;

            str.Visible = true;
            dex.Visible = true;
            con.Visible = true;
            inte.Visible = true;
            wis.Visible = true;
            cha.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.lvlup = -1;
            UpdateGeneral();
            hide_all();
            button4.Visible = false;
            button1.Enabled = true;
            if (level.Text == "20") button1.Enabled = false;

            str.Visible = false;
            dex.Visible = false;
            con.Visible = false;
            inte.Visible = false;
            wis.Visible = false;
            cha.Visible = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
          

            if (string.IsNullOrWhiteSpace(name_box.Text))
            {
                name_box.BackColor = Color.Pink;
            }
            else
            {
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    formater.Serialize(fs, player);
                    fs.Close();
                }
            }
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            name_box.BackColor = Color.White;
            player.name = name_box.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.p_class = class_box.Text.ToString();
        }

        private void skills_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skills_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pic_open.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.Image = new Bitmap(pic_open.FileName);
                player.player_image= new Bitmap(pic_open.FileName);

            }
        }

        private void spells_Click(object sender, EventArgs e)
        {
            spell_sheet = new Spells();
            spell_sheet.setParent(this);
            spell_sheet.Show();
        }

        private void load_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();


            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            player=(Player)formater.Deserialize(fs);
            UpdateGeneral();
            fs.Close();
            
            
        }

        
    }
}

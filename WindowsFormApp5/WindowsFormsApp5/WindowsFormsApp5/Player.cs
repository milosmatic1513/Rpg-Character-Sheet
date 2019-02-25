using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    [Serializable]
    public class Player
    {
        public Hashtable player_stats = new Hashtable();

        public string[] ability_names = new string[] { "str", "dex", "con", "int", "wis", "cha" };
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
        public string name = "";
        public int level = 1;
        public string p_class = "";
        public Image player_image = null;
        public bool[] saving_throws = new bool[6];
        public List<Spell_class> spells = new List<Spell_class>();

        public int hp, temp_hp;

        public string cp="", sp="", gp="" ,pp="";//coin

        public string equipment;



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
                    {"Investigation","int"},
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

            abProfs = new bool[abChecks.GetLength(0), 2];

            for (int i = 0; i < abProfs.GetLength(0); i++)
            {
                abProfs[i, 0] = false;
                abProfs[i, 1] = false;
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
}

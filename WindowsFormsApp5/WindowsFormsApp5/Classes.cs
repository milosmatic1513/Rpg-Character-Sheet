using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp5
{
    public partial class Classes : Form
    {
        int columns;
        classRow spellSlots;
        bool first;
        classRow oldTop;
        List<classRow> spellDisplay;
        comboBoxAdder armorBox, weaponBox, toolBox, savingBox, skillBox;
        List<descriptionControl> description;

        public Classes()
        {
            InitializeComponent();
            columns = 5;
            first = true;
            description = new List<descriptionControl>();
        }

        public void setSpellAdder(string l)
        {
            int lvl = int.Parse(l);
            for (int i = lvl; i < 20; i++)
            {
                spellDisplay[i].setText(spellDisplay[i - 1], false);
            }
        }

        private void UpdatePanels()
        {
            if (!first)
            {
                List<classRow> oldMain = new List<classRow>();
                foreach (classRow s in mainDisplay.Controls)
                {
                    oldMain.Add(s);
                }

                topBar.Controls.Clear();
                mainDisplay.Controls.Clear();

                classRow c = new classRow(columns, 0, false);
                c.setText(oldTop, true);
                topBar.Controls.Add(c);
                oldTop = c;

                for (int i = 0; i < 20; i++)
                {
                    classRow cR = new classRow(columns, i + 1, false);
                    cR.setText(oldMain[i], true);
                    mainDisplay.Controls.Add(cR);
                }
            }
            else
            {
                classRow c = new classRow(columns, 0, false);
                spellDisplay = new List<classRow>();
                c.setLvlText("LV");
                topBar.Controls.Add(c);
                oldTop = c;

                for (int i = 0; i < 20; i++)
                {
                    classRow cR = new classRow(columns, i + 1, false);
                    mainDisplay.Controls.Add(cR);
                }
            }
            first = false;
        }

        private void hitDie_TextChanged(object sender, EventArgs e)
        {
            hitDie.BackColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            descriptionControl tmp = new descriptionControl();
            description.Add(tmp);
            descriptions.Controls.Add(tmp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (description.Count > 0)
            {
                descriptions.Controls.Remove(description[description.Count - 1]);
                description.Remove(description[description.Count - 1]);
            }
        }

        private void className_TextChanged(object sender, EventArgs e)
        {
            className.BackColor = Color.White;
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            UpdatePanels();
            classRow c = new classRow(11, 0, false);
            c.setText(new List<string> { "Cantrip", "Lv1", "Lv2", "Lv3", "Lv4", "Lv5", "Lv6", "Lv7", "Lv8", "Lv9" }, "LV");
            topSpells.Controls.Add(c);
            spellSlots = c;

            for (int i = 0; i < 20; i++)
            {
                classRow cR = new classRow(11, i + 1, true);
                mainSpells.Controls.Add(cR);
                spellDisplay.Add(cR);
            }

            armorBox = new comboBoxAdder();
            armorBox.setItems(new List<string> { "Light Armor", "Medium Armor", "Heavy Armor", "Shield", "None" });
            armorBox.Location = new Point(label3.Location.X, label3.Location.Y + label3.Height + 5);
            this.Controls.Add(armorBox);
            weaponBox = new comboBoxAdder();
            weaponBox.setItems(new List<string> { "Simple Weapons", "Martial Weapons", "Hand Crossbows", "Longswords", "Rapiers", "Simple Ranged Weapons", "Martial ranged Weapons" });
            weaponBox.Location = new Point(label4.Location.X, label4.Location.Y + label4.Height + 5);
            this.Controls.Add(weaponBox);
            toolBox = new comboBoxAdder();
            toolBox.setItems(new List<string> { "Bagpipes", "Drum", "Dulcimer", "Flute", "Lute", "Lyre", "Horn", "Pan flute", "Shawm", "Viol", "Navigator’s tools", "Thieves’ tools", "Vehicles (land or water)", "Dice set", "Playing Card Set", "Carpenter’s tools", "Cartographer’s tools", "Cartographer’s tools", "Glassblower’s tools", "Jeweler’s tools", "Leatherworker’s tools", "Mason’s tools", "Potter’s tools", "Smith’s tools", "Tinker’s tools", "Weaver’s tools", "Woodcarver’s tools", "None" });
            toolBox.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 5);
            this.Controls.Add(toolBox);
            savingBox = new comboBoxAdder();
            savingBox.setItems(new List<string> { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" });
            savingBox.Location = new Point(label6.Location.X, label6.Location.Y + label6.Height + 5);
            this.Controls.Add(savingBox);
            skillBox = new comboBoxAdder();
            skillBox.setItems(new List<string> { "Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "History", "Insight", "Intimidation", "Investigation", "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand", "Stealth", "Survival" });
            skillBox.Location = new Point(label7.Location.X, label7.Location.Y + label7.Height + 5);
            this.Controls.Add(skillBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (columns < 10)
            {
                columns++;
                UpdatePanels();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (columns > 2)
            {
                columns--;
                UpdatePanels();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isNumeric(string s)
        {
            try
            {
                int i = int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> tmp = oldTop.getText();
            bool pass = true;
            bool pass1 = true;
            foreach (string s in tmp)
            {
                if (s == "")
                {
                    pass = false;
                    break;
                }
            }
            if (className.Text == "")
            {
                pass1 = false;
                className.BackColor = Color.Pink;
            }
            if (hitDie.Text == "" || isNumeric(hitDie.Text))
            {
                pass1 = false;
                hitDie.BackColor = Color.Pink;
            }
            if (isNumeric(hitDie.Text))
            {
                int i = int.Parse(hitDie.Text);
                if (i <= 0)
                {
                    pass1 = false;
                    hitDie.BackColor = Color.Pink;
                    MessageBox.Show("Hit die must be a number greater than 0");
                }
            }
            if (armorBox.selected.Count == 0)
            {
                pass1 = false;
                armorBox.setError();
            }
            if (weaponBox.selected.Count == 0)
            {
                pass1 = false;
                weaponBox.setError();
            }
            if (toolBox.selected.Count == 0)
            {
                pass1 = false;
                toolBox.setError();
            }
            if (savingBox.selected.Count == 0)
            {
                pass1 = false;
                savingBox.setError();
            }
            if (skillBox.selected.Count == 0)
            {
                pass1 = false;
                skillBox.setError();
            }
            if (pass && pass1)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Classes.xml");
                //<Class>
                XmlNode classs = doc.CreateElement("Class");
                //<Name>
                XmlNode name = doc.CreateElement("Name");
                name.InnerText = className.Text;
                classs.AppendChild(name);
                //</Name>
                //<Levels>
                XmlNode levels = doc.CreateElement("Levels");
                List<string> spellSl = spellSlots.getText();
                int k = 0;
                foreach (classRow cR in mainDisplay.Controls)
                {
                    //<Lvl>
                    XmlNode lvl = doc.CreateElement("Lvl");
                    //<Level>
                    XmlNode level = doc.CreateElement("Level");
                    level.InnerText = cR.getLevel();
                    lvl.AppendChild(level);
                    //</Level>
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        //<tmp[i]>
                        XmlNode tmpi = doc.CreateElement(tmp[i]);
                        tmpi.InnerText = cR.getText()[i];
                        lvl.AppendChild(tmpi);
                        //</tmp[i]>
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        //<spellSl[i]>
                        XmlNode spellsSli = doc.CreateElement(spellSl[i]);
                        spellsSli.InnerText = spellDisplay[k].getText()[i];
                        lvl.AppendChild(spellsSli);
                        //</spellSl[i]>
                    }
                    k++;
                    levels.AppendChild(lvl);
                    //</Lvl>;
                }
                classs.AppendChild(levels);
                //</Levels>
                //<Hit_Die>
                XmlNode hitdie = doc.CreateElement("Hit_Die");
                hitdie.InnerText = hitDie.Text;
                classs.AppendChild(hitdie);
                //</Hit_Die>
                //<Armor_Proficiency>
                XmlNode armorProficiency = doc.CreateElement("Armor_Proficiency");
                string tmpS = "";
                foreach (string s in armorBox.selected)
                {
                    tmpS += s + ", ";
                }
                tmpS = tmpS.Remove(tmpS.Length - 2);
                armorProficiency.InnerText = tmpS;
                classs.AppendChild(armorProficiency);
                //</Armor_Proficiency>
                //<Weapons_Proficiency>
                XmlNode weaponsProficiency = doc.CreateElement("Weapons_Proficiency");
                tmpS = "";
                foreach (string s in weaponBox.selected)
                {
                    tmpS += s + ", ";
                }
                tmpS = tmpS.Remove(tmpS.Length - 2);
                weaponsProficiency.InnerText = tmpS;
                classs.AppendChild(weaponsProficiency);
                //</Weapons_Proficiency>
                //<Tools_Proficiency>
                XmlNode toolsProficiency = doc.CreateElement("Tools_Proficiency");
                //<Proficiencies>
                XmlNode proficiencies = doc.CreateElement("Proficiencies");
                tmpS = "";
                foreach (string s in toolBox.selected)
                {
                    tmpS += s + ", ";
                }
                tmpS = tmpS.Remove(tmpS.Length - 2);
                proficiencies.InnerText = tmpS;
                toolsProficiency.AppendChild(proficiencies);
                //</Proficiencies>
                //<Details>
                XmlNode details = doc.CreateElement("Details");
                details.InnerText = toolsDesc.Text;
                toolsProficiency.AppendChild(details);
                //</Details>
                classs.AppendChild(toolsProficiency);
                //</Tools_Proficiency>
                //<Saving_Throws_Proficiency>
                XmlNode saving = doc.CreateElement("Saving_Throws_Proficiency");
                tmpS = "";
                foreach (string s in savingBox.selected)
                {
                    tmpS += s + ", ";
                }
                tmpS = tmpS.Remove(tmpS.Length - 2);
                saving.InnerText = tmpS;
                classs.AppendChild(saving);
                //</Saving_Throws_Proficiency>
                //<Skill_Proficiency>
                XmlNode skill = doc.CreateElement("Skill_Proficiency");
                //<Proficiencies>
                XmlNode prof = doc.CreateElement("Proficiencies");
                tmpS = "";
                foreach (string s in skillBox.selected)
                {
                    tmpS += s + ", ";
                }
                tmpS = tmpS.Remove(tmpS.Length - 2);
                prof.InnerText = tmpS;
                skill.AppendChild(prof);
                //</Proficiencies>
                //<Details>
                XmlNode det = doc.CreateElement("Details");
                det.InnerText = skillDesc.Text;
                skill.AppendChild(det);
                //</Details>
                classs.AppendChild(skill);
                //</Skill_Proficiency>
                //<Descriptions>
                XmlNode descriptions = doc.CreateElement("Descriptions");
                foreach (descriptionControl s in description)
                {
                    //<Description>
                    XmlNode desc = doc.CreateElement("Description");
                    //<Name>
                    XmlNode Name = doc.CreateElement("Name");
                    Name.InnerText = s.getName();
                    desc.AppendChild(Name);
                    //</Name>
                    //<Desc>
                    XmlNode descr = doc.CreateElement("Desc");
                    descr.InnerText = s.getDesc();
                    desc.AppendChild(descr);
                    //</Desc>
                    descriptions.AppendChild(desc);
                    //</Description>
                }
                classs.AppendChild(descriptions);
                //</Descriptions>
                doc.DocumentElement.AppendChild(classs);
                //</Class>
                doc.Save("Classes.xml");
                MessageBox.Show("Save successfull");
                this.Close();
            }
            else if (!pass && pass1)
            {
                MessageBox.Show("Fill out all the row headers");
            }
            else if (className.Text == "")
            {
                MessageBox.Show("Maybe give the Class a name ?");
            }
            else
            {
                MessageBox.Show("Unknown error");
            }
        }
    }
}

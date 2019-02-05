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
    public partial class AbilitySkill : UserControl
    {
        public int ac;
        int modifier, proficience, strReq, defaultAc, maxDex, dexterity, strength;
        bool armor;

        public AbilitySkill()
        {
            InitializeComponent();
            modifier = 0;
            proficience = 2;
            armor = false;
            ac = 10;
            strReq = 0;
            dexterity = 10;
            strength = 10;
            defaultAc = 10;
            maxDex = 20;
        }

        public void ChangeState(bool s)
        {
            prof.Checked = s;
        }

        public void SetAll_Skills(string n, string s, int mo, int pro)
        {
            skill.Text = n + " ( " + s + " )";
            modifier = mo;
            if (mo >= 0) mod.Text = "+" + mo.ToString();
            else mod.Text = mo.ToString();
            proficience = pro;
            doubleProf.Location = new Point(skill.Width + skill.Location.X + 5, doubleProf.Location.Y);
        }

        public void SetAll_Tools(string n, int pro)
        {
            skill.Text = n;
            mod.Text = "+0";
            proficience = pro;
            doubleProf.Location = new Point(skill.Width + skill.Location.X + 5, doubleProf.Location.Y);
        }

        public void SetAll_Armor(string n, int dis, int maxD, int dex, int str, int acDef, int strScore)
        {
            armor = true;
            strReq = str;
            strength = strScore;
            dexterity = dex;
            defaultAc = acDef;
            maxDex = maxD;
            doubleProf.Visible = false;
            if (dis == 0) mod.Text = "-";
            else mod.Text = "Dis";
            skill.Text = n;
            if (strength >= strReq) prof.Enabled = true;
            else prof.Enabled = false;
        }

        public string GetName()
        {
            return skill.Text;
        }

        public void UpdateMod(int x, int p)  //if we Updating armors x = dexterity modifier , p = strength modifier
        {                                    //else  x = stat modifier , p = proficiency
            if (!armor)
            {
                modifier = x;
                proficience = p;
                if (doubleProf.Checked)
                {
                    if (2 * p + x >= 0) mod.Text = "+" + (2 * p + x).ToString();
                    else mod.Text = (2 * p + x).ToString();
                }
                else if (prof.Checked)
                {
                    if (p + x >= 0) mod.Text = "+" + (p + x).ToString();
                    else mod.Text = (p + x).ToString();
                }
                else
                {
                    if (x >= 0) mod.Text = "+" + x.ToString();
                    else mod.Text = x.ToString();
                }
            }
            else
            {
                dexterity = x;
                strength = p;
                if (prof.Checked)
                {
                    ac = defaultAc;
                    if ((dexterity > maxDex && maxDex != -1) || maxDex == 0) ac += maxDex;
                    else ac += dexterity;
                }
                if (strength >= strReq) prof.Enabled = true;
                else prof.Enabled = false;
            }
        }

        private void AbilitySkill_Load(object sender, EventArgs e)
        {
        }

        private void doubleProf_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMod(modifier, proficience);
        }

        public bool Checked()
        {
            return prof.Checked;
        }

        private void prof_CheckedChanged(object sender, EventArgs e)
        {
            if (!armor)
            {
                if (prof.Checked)
                {
                    doubleProf.Enabled = true;
                    UpdateMod(modifier, proficience);
                }
                else
                {
                    doubleProf.Checked = false;
                    doubleProf.Enabled = false;
                    UpdateMod(modifier, proficience);
                }
            }
            else
            {
                UpdateMod(dexterity, strength);
            }
        }
    }
}

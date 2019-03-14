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
    public partial class SpellDisplay : Form
    {
        cha_save mainForm;
        Spells parentForm;
        bool autoFiltered;

        public SpellDisplay(cha_save p, Spells s, bool aF)
        {
            InitializeComponent();
            mainForm = p;
            parentForm = s;
            autoFiltered = aF;
        }

        private string SpellNotIncluded(string search)
        {
            string filter = "";
            string tmp = search;
            foreach (Spell_class s in mainForm.getSpells())
            {
                if (tmp == "")
                {
                    filter += "Name NOT LIKE '%" + s.name + "%'";
                    tmp += "1";
                }
                else filter += " AND Name NOT LIKE '%" + s.name + "%'";
            }
            return filter;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Spells.xml");
                dataGridView1.DataSource = ds.Tables[0];
                string search = "";
                search = SpellNotIncluded(search);
                if (autoFiltered && search == "") search += "Class LIKE '%" + mainForm.GetClass() + "%'";
                else if (autoFiltered) search += " AND Class LIKE '%" + mainForm.GetClass() + "%'";
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.DefaultView.RowFilter = search;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string s = "";
                s += "Name : ";
                s += dataGridView1[0, e.RowIndex].Value.ToString();
                s += "\n\nClasses :  ";
                s += dataGridView1[1, e.RowIndex].Value.ToString();
                s += "\n\nSchool : ";
                s += dataGridView1[7, e.RowIndex].Value.ToString();
                s += "\n\nLevel : ";
                s += dataGridView1[2, e.RowIndex].Value.ToString();
                s += "\n\nCasting : ";
                s += dataGridView1[3, e.RowIndex].Value.ToString();
                s += "\n\nRange : ";
                s += dataGridView1[4, e.RowIndex].Value.ToString();
                s += "\n\nComponents : ";
                s += dataGridView1[5, e.RowIndex].Value.ToString();
                s += "\n\nDuration : ";
                s += dataGridView1[6, e.RowIndex].Value.ToString();
                s += "\n\nDescription :\n";
                s += dataGridView1[8, e.RowIndex].Value.ToString();
                DialogResult dr = MessageBox.Show(s, "ADD THIS SPELL ?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    mainForm.addSpell(new Spell_class(dataGridView1[0, e.RowIndex].Value.ToString(), dataGridView1[3, e.RowIndex].Value.ToString(), dataGridView1[5, e.RowIndex].Value.ToString(), dataGridView1[6, e.RowIndex].Value.ToString(), dataGridView1[8, e.RowIndex].Value.ToString(), dataGridView1[4, e.RowIndex].Value.ToString(), dataGridView1[1, e.RowIndex].Value.ToString(), dataGridView1[2, e.RowIndex].Value.ToString(), dataGridView1[7, e.RowIndex].Value.ToString()));
                    parentForm.Update();
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = nameSearch.Text;
            string casting = (castingSearch.Text == "Any") ? "" : castingSearch.Text;
            string comp = (compSearch.Text == "Any") ? "" : compSearch.Text;
            string dur = (durSearch.Text == "Any") ? "" : durSearch.Text;
            string clas = mainForm.GetClass();

            string search = "Name LIKE '%" + name + "%' AND Casting LIKE '%" + casting + "%' AND Components LIKE '%" + comp + "%' AND Duration LIKE '%" + dur + "%'";
            search += SpellNotIncluded(search);
            if (autoFiltered) search += " AND Class LIKE '%" + mainForm.GetClass() + "%'";
            DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.DefaultView.RowFilter = search;
            dataGridView1.DataSource = dt;
        }
    }
}

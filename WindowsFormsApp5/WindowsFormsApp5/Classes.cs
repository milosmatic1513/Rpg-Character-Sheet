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
        classRow top, spellSlots;
        bool first;
        classRow oldTop;
        List<classRow> spellDisplay;

        public Classes()
        {
            InitializeComponent();
            columns = 5;
            first = true;
        }

        public void setSpellAdder(string l)
        {
            int lvl = int.Parse(l);
            for (int i = lvl; i < 20; i++)
            {
                spellDisplay[i].setText(spellDisplay[i - 1],false);
            }
        }

        private void UpdatePanels()
        {
            if (!first)
            {
                oldTop = top;
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
                top = c;

                for (int i = 0; i < 20; i++)
                {
                    classRow cR = new classRow(columns, i + 1, false);
                    cR.setText(oldMain[i], true);
                    mainDisplay.Controls.Add(cR);
                }
            }
            else
            {
                topBar.Controls.Clear();
                mainDisplay.Controls.Clear();

                classRow c = new classRow(columns, 0, false);
                spellDisplay = new List<classRow>();
                c.setLvlText("LV");
                topBar.Controls.Add(c);
                top = c;

                for (int i = 0; i < 20; i++)
                {
                    classRow cR = new classRow(columns, i + 1, false);
                    mainDisplay.Controls.Add(cR);
                }
            }
            first = false;
        }
        
        private void Classes_Load(object sender, EventArgs e)
        {
            UpdatePanels();
            classRow c = new classRow(11, 0, false);
            c.setText(new List<string> { "Cantrip", "1", "2", "3", "4", "5", "6", "7", "8", "9" }, "LV");
            topSpells.Controls.Add(c);
            spellSlots = c;

            for (int i = 0; i < 20; i++)
            {
                classRow cR = new classRow(11, i + 1, true);
                mainSpells.Controls.Add(cR);
                spellDisplay.Add(cR);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> tmp = top.getText();
            bool pass = true;
            foreach (string s in tmp)
            {
                if (s == "")
                {
                    pass = false;
                    break;
                }
            }
            if (pass)
            {
                XmlTextWriter doc = new XmlTextWriter("Classes.xml", Encoding.UTF8);
                doc.Formatting = Formatting.Indented;
                doc.WriteStartElement("Classes"); //<Classes>
                doc.WriteStartElement("Class"); //<Class>
                doc.WriteStartElement("Name"); //<Name>
                doc.WriteString(top.getText()[0]);
                doc.WriteEndElement(); //</Name>
                doc.WriteStartElement("Levels"); //<Levels>
                List<string> spellSl = spellSlots.getText();
                int k = 0;
                foreach (classRow cR in mainDisplay.Controls)
                {
                    doc.WriteStartElement("Level"); //<Level>
                    doc.WriteStartElement("Current"); //<Current>
                    doc.WriteString(cR.getLevel());
                    doc.WriteEndElement(); //</Current>
                    for (int i = 0; i < tmp.Count - 1; i++)
                    {
                        doc.WriteStartElement(tmp[i]); //<tmp[i]>
                        doc.WriteString(cR.getText()[i]);
                        doc.WriteEndElement(); //</tmp[i]>
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        doc.WriteStartElement(spellSl[i]); //<spellSl[i]>
                        doc.WriteString(spellDisplay[k].getText()[i]);
                        doc.WriteEndElement(); //</spellSl[i]>
                    }
                    doc.WriteEndElement(); //</Level>
                    k++;
                }
                doc.WriteEndElement(); //</Levels>
                doc.WriteEndElement(); //</Class>
                doc.WriteEndElement(); //</Classes>
                doc.Close();
                MessageBox.Show("Save successfull");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill out all the row headers");
            }
        }
    }
}

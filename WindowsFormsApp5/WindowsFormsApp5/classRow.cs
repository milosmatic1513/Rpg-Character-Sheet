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
    public partial class classRow : UserControl
    {
        public int columns;
        public List<TextBox> rch;
        bool isSpellSlot,changing;

        public classRow(int col,int level, bool s)
        {
            InitializeComponent();
            columns = col;
            lvl.Text = level.ToString();
            rch = new List<TextBox>();
            isSpellSlot = s;
            changing = false;


            rch.Clear();
            int len = (this.Width - 30) / (columns - 1) - 5;
            textBox1.Width = len;
            if (isSpellSlot)
            {
                textBox1.TextChanged += keyListener_TextChanged;
                textBox1.KeyDown += keyListener_KeyDown;
            }
            rch.Add(textBox1);
            for (int i = 1; i < columns - 1; i++)
            {
                TextBox r = new TextBox();
                rch.Add(r);
                rch[i].BackColor = textBox1.BackColor;
                rch[i].Font = textBox1.Font;
                rch[i].ForeColor = textBox1.ForeColor;
                rch[i].Size = textBox1.Size;
                rch[i].Location = new Point(rch[i - 1].Location.X + rch[i - 1].Width + 5, textBox1.Location.Y);
                if (isSpellSlot)
                {
                    rch[i].TextChanged += keyListener_TextChanged;
                    rch[i].KeyDown += keyListener_KeyDown;
                }
                this.Controls.Add(rch[i]);
            }
        }

        public void setLvlText(string l)
        {
            lvl.Text = l;
        }

        public string getLevel()
        {
            return lvl.Text;
        }

        public void setText(classRow s, bool changeLevel)
        {
            int t;
            if (s.columns < columns) t = s.columns;
            else t = columns;
            
            
            for (int i = 0; i < t - 1; i++)
            {
                rch[i].Text = s.getText()[i];
            }
            if (changeLevel) lvl.Text = s.getLevel();
        }

        public void setText(List<string> s, string l)
        {
            classRow_Load(null, null);

            for (int i = 0; i < s.Count; i++)
            {
                rch[i].Text = s[i];
            }
            lvl.Text = l;
        }

        public List<string> getText()
        {
            List<string> ret = new List<string>();
            foreach (TextBox t in rch)
            {
                ret.Add(t.Text);
            }
            return ret;
        }

        private void classRow_Load(object sender, EventArgs e)
        {
        }

        private void keyListener_TextChanged(object sender, EventArgs e)
        {
            if (changing)
            {
                ((Classes)ParentForm).setSpellAdder(this.lvl.Text);
                changing = false;
            }
        }

        private void keyListener_KeyDown(object sender, KeyEventArgs e)
        {
            if (!changing)
            {
                changing = true;
            }
        }
    }
}

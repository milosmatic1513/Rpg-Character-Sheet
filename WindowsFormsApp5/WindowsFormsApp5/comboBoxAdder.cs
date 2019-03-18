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
    public partial class comboBoxAdder : UserControl
    {
        public List<string> selected;

        public comboBoxAdder()
        {
            InitializeComponent();
            selected = new List<string>();
        }

        public void setItems(List<string> s)
        {
            foreach (string k in s)
            {
                comboBox1.Items.Add(k);
            }
        }

        public void setError()
        {
            flowLayoutPanel1.BackColor = Color.Pink;
        }
        
        public void insertItemBack(string n)
        {
            comboBox1.Items.Add(n);
            foreach (string s in selected)
            {
                if (s == n)
                {
                    selected.Remove(s);
                    break;
                }
            }

            foreach (deletableBar s in flowLayoutPanel1.Controls)
            {
                if (s.getName() == n)
                {
                    flowLayoutPanel1.Controls.Remove(s);
                    break;
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            string sel = comboBox1.Items[i].ToString();
            selected.Add(sel);
            comboBox1.Items.RemoveAt(i);
            flowLayoutPanel1.Controls.Add(new deletableBar(sel, this));
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.White;
        }
    }
}

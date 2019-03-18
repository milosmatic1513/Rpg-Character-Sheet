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
    public partial class deletableBar : UserControl
    {
        comboBoxAdder parentControl;

        public deletableBar(string n, comboBoxAdder c)
        {
            InitializeComponent();
            label1.Text = n;
            parentControl = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentControl.insertItemBack(label1.Text);
        }

        public string getName()
        {
            return label1.Text;
        }
    }
}

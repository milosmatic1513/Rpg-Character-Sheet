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
    public partial class classesMidway : Form
    {
        public classesMidway()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes cl = new Classes();
            cl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classDelete tbd = new classDelete(0);
            tbd.Show();
        }
    }
}

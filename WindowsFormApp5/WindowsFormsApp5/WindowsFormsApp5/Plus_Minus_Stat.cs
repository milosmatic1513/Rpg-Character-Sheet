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
    public partial class Plus_Minus_Stat : UserControl
    {
        cha_save parentForm;
        string stat_name;

        public Plus_Minus_Stat()
        {
            InitializeComponent();
            parentForm = null;
            stat_name = null;
        }

        public void Set_Stats(string name)
        {
            stat_name = name;
        }
        
        public void Set_Parent(cha_save par)
        {
            parentForm = par;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            int tmp = parentForm.GetStatScore(stat_name);
            parentForm.SetStatScore(stat_name, ++tmp);
            if (tmp == 24)
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            int tmp = parentForm.GetStatScore(stat_name);
            parentForm.SetStatScore(stat_name, --tmp);
            if (tmp == 1)
            {
                button2.Enabled = false;
            }
        }
    }
}

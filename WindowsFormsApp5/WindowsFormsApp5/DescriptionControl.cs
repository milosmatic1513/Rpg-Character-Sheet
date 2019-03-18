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
    public partial class descriptionControl : UserControl
    {
        public descriptionControl()
        {
            InitializeComponent();
        }

        public string getName()
        {
            return name.Text;
        }
         public string getDesc()
        {
            return desc.Text;
        }
    }
}

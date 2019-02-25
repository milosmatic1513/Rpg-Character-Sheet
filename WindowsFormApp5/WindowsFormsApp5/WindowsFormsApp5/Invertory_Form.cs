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
    public partial class Invertory_Form : Form
    {
        Player player=new Player();
        public Invertory_Form()
        {
            InitializeComponent();
        }

        public Invertory_Form(Player player_temp)
        {
            player = player_temp;
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Invertory_Form_Load(object sender, EventArgs e)
        {
            cp.Text = player.cp;
            sp.Text = player.sp;
            gp.Text = player.gp;
            pp.Text = player.pp;
            eq.Text = player.equipment;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.cp = cp.Text;
            player.sp = sp.Text;
            player.gp = gp.Text; 
            player.pp = pp.Text; 
            player.equipment = eq.Text;
            this.Close();
        }
    }
}

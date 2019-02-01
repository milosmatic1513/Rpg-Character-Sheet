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
    
    public partial class AbilityScore : UserControl
    {
        public AbilityScore()
        {
            InitializeComponent();
        }

        public void Ability(string name)
        {
            label1.Text = name;
            AbilityScore_Load(null, null);
        }

        public void SetScore(int score)
        {
            textBox1.Text = score.ToString();
            AbilityScore_Load(null, null);
        }

        public int GetScore()
        {
            return int.Parse(textBox1.Text);
        }

        public int GetModifier()
        {
            return int.Parse(label2.Text);
        }

        private void AbilityScore_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(5, 5);
            int x = 0;
            while (true)
            {
                label1.Font = new Font("Arial", this.Height / 5 - x);
                if (label1.Width + label1.Location.X < this.Width && label1.Height <= this.Width / 5) break;
                x++;
            }
            label1.Location = new Point((this.Width - label1.Width) / 2, 5);
            textBox1.Font = new Font("Arial", this.Height / 5);
            textBox1.Width = textBox1.Height;
            textBox1.Location = new Point((this.Width - textBox1.Width) / 2, label1.Location.Y + label1.Height);
            label2.Font = textBox1.Font;
            label2.Location = new Point((this.Width - label2.Width) / 2, textBox1.Location.Y + textBox1.Height - 2);
            if ((int.Parse(textBox1.Text) - 10) >= 0) label2.Text = ((int.Parse(textBox1.Text) - 10) / 2).ToString();
            else label2.Text = ((int.Parse(textBox1.Text) - 11) / 2).ToString();
            if (int.Parse(label2.Text) >= 0) label2.Text = "+" + label2.Text;
        }
    }
}

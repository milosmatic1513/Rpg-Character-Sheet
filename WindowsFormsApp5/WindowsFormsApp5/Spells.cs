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
    public partial class Spells : Form
    {
        List<Spell_class> spells;
        int last_y;
        Spell_creation sp;
        cha_save parentForm;

        public Spells()
        {
            InitializeComponent();
        }

        public void Update()
        {
            flowLayoutPanel1.Controls.Clear();
            int index = 0;
            foreach (Spell_class sp in parentForm.getSpells())
            {
                spell ab = new spell(sp.name, sp.casting_time, sp.components, sp.duration, sp.description, sp.range, sp.clas, sp.lvl, sp.sch, index, this);
                ab.Location = new Point(5, 0);
                flowLayoutPanel1.Controls.Add(ab);
                index++;
            }
        }

        public cha_save getParent()
        {
            return parentForm;
        }

        private void Spells_Load(object sender, EventArgs e)
        {
            Update();
            spells = new List<Spell_class>();
        }
        public void setParent(cha_save parent)
        {
            parentForm = parent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sp = new Spell_creation(parentForm);
            sp.ShowDialog();
            if (sp.c1)
            {
                parentForm.addSpell(new Spell_class(sp.spell_name, sp.casting_time, sp.comps, sp.duration, sp.desc, sp.range, sp.clas, sp.level, sp.sch));
                Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpellDisplay spd = new SpellDisplay(parentForm, this, true);  //Class specific spells
            spd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpellDisplay spd = new SpellDisplay(parentForm, this, false);  //All spells
            spd.Show();
        }
    }
}
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
    public partial class classDelete : Form
    {
        int index;

        public classDelete(int i)
        {
            InitializeComponent();
            index = i;
        }

        private void ToBeDeleted_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Classes.xml");
            dataGridView1.DataSource = ds.Tables[index];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to DELETE the class : " + dataGridView1[0, e.RowIndex].Value.ToString(), "DELETING CLASS", MessageBoxButtons.YesNo);
            if (dr.Equals(DialogResult.Yes))
            {
                if (e.RowIndex >= 0)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("Classes.xml");
                    foreach (XmlNode xN in doc.SelectNodes("Classes/Class"))
                    {
                        if (xN.SelectSingleNode("Name").InnerText == dataGridView1[0, e.RowIndex].Value.ToString()) xN.ParentNode.RemoveChild(xN);
                    }
                    doc.Save("Classes.xml");

                    DataSet ds = new DataSet();
                    ds.ReadXml("Classes.xml");
                    dataGridView1.DataSource = ds.Tables[index];
                }
            }
        }
    }
}

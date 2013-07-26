using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{ 
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.dataSet1.Product);
            cmbType.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearList();
            var q = from p in this.dataSet1.Product
                    select p;

            if (q.Count() > 0)
            {
                if (txtName.Text.Trim().Length > 0)
                {
                    switch (cmbType.SelectedIndex)
                    {
                        case 0:
                            q = from p in this.dataSet1.Product
                                where p.ID.ToString() == (txtName.Text.Trim()) | p.Name.StartsWith(txtName.Text.Trim())
                                select p;
                            break;
                        case 1:
                            q = from p in this.dataSet1.Product
                                where p.ID.ToString() == (txtName.Text.Trim())
                                select p;
                            break;
                        case 2:
                            q = from p in this.dataSet1.Product
                                where p.Name.StartsWith(txtName.Text.Trim())
                                select p;
                            break;
                        default:
                            break;
                    }
                }
                foreach (var n in q)
                {
                    string[] row = { n.ID.ToString(), n.Name.ToString() };
                    var lvi = new ListViewItem(row);
                    listView1.Items.Add(lvi);
                }
                countList();
            }
        }

        private void countList()
        {
         //   toolStripLabel1.Text = Convert.ToString(listView1.Items.Count);
        }

        private void clearList()
        {
            listView1.Items.Clear();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmDatabase = new frmDatabase();
            frmDatabase.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frmDatabase = new frmDatabase();
            frmDatabase.Show();
        }  
    }
}

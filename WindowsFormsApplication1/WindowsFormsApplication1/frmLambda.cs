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
    public partial class frmLambda : Form
    {
        public frmLambda()
        {
            InitializeComponent();
        }
             
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var q = from p in this.dataSet1.Product    
                    select p;



            IEnumerable<string> query = Enumerable.Empty<string>();   
            switch (cmbType.SelectedIndex)
            {
                case 0:
                    query = q.Where(n => n.Name.StartsWith(txtName.Text.Trim()))
                             .Select(n => n.Name);
                    break;
                case 1:
                    query = q.Where(n => n.Name.StartsWith(txtName.Text.Trim()))
                             .Select(n => n.Name.ToUpper());
                    break;
                case 2:
                    query = q.Where(n => n.Name.StartsWith(txtName.Text.Trim()))
                             .Select(n => n.Name.ToLower());
                    break;

            }
                  foreach (var n in query)
                  listView1.Items.Add(n);           
        }

        private void frmLambda_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = Enum.GetValues(typeof (typeProduct));
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }
    }

    enum typeProduct
    {   
        Original,
        Upper,
        Lower
    };

}

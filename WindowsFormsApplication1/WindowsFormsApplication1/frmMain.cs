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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();   
        }

        private void fizzBuzzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmFizz = new frmFizzBuzz();
            frmFizz.MdiParent = this;
            frmFizz.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCal = new frmCalculate();
            frmCal.MdiParent = this;
            frmCal.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSearch = new frmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void testForCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBasic = new frmBasic();
            frmBasic.MdiParent = this;
            frmBasic.Show();
        }

        private void lambdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLam = new frmLambda();
            frmLam.MdiParent = this;
            frmLam.Show();
        }

    
    }
}

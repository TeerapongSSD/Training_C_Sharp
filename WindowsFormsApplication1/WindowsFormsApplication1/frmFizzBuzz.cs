using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;

namespace WindowsFormsApplication1
{
    public partial class frmFizzBuzz : Form
    {
        public frmFizzBuzz()
        {
            InitializeComponent();
        }

        private void frmFizzBuzz_Load(object sender, EventArgs e)
        {
    
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            var naturalNumbers = Enumerable.Range(1, 100);

            foreach (var n in naturalNumbers)
            {
                if (n % 15 == 0) { listBox1.Items.Add("FizzBuzz"); continue; }

                if (n % 3 == 0) { listBox1.Items.Add("Fizz"); continue; }

                if (n % 5 == 0) { listBox1.Items.Add("Buzz"); continue; }

                listBox1.Items.Add(n);
            }
        }
    }
}

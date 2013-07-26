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
    public partial class frmCalculate : Form
    {
        public frmCalculate()
        {
            InitializeComponent();
        }

        private void frmCalculate_Load(object sender, EventArgs e)
        {
            cmbCal.SelectedIndex = 0;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
     
            if ((Convert.ToInt32(txtNum1.Text.Length) < 1) | (Convert.ToInt32(txtNum2.Text.Length) < 1))
            {
                MessageBox.Show("Please Insert Number");
                txtResult.Text = "";
                return;
            }

            switch (Convert.ToString(cmbCal.SelectedItem))
            {
                case "+":
                    txtResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text));
                    break;
                case "-":
                    txtResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text));
                    break;
                case "*":
                    txtResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text));
                    break;
                case "/":
                    txtResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text));
                    break;
                case "Mod":
                    txtResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) % Convert.ToDouble(txtNum2.Text));
                    break;

                default:
                    break;
            }
        }

        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum2.Focus();
            }

        }

        private void txtNum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCal.Focus();
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((txtNum1.Text.Trim() + e.KeyChar.ToString()).Split('.').Length > 2)
                e.Handled = true;
            else if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((txtNum2.Text.Trim() + e.KeyChar.ToString()).Split('.').Length > 2)
                e.Handled = true;
            else if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}

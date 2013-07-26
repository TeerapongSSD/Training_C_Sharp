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


    public partial class frmBasic : Form
    {
        public frmBasic()
        {
            InitializeComponent();
        }

        private void frmBasic_Load(object sender, EventArgs e)
        {

        }

        #region Parameter Test

        private void btnParameter_Click(object sender, EventArgs e) // Parameter
        {
            if (txtNum1.Text.Length > 0)
            {
                txtResult1.Text = FeetToInches(Convert.ToInt32(txtNum1.Text.ToString())).ToString();
            }
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {      
            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }

        #endregion     

        #region Upper Lower

        private void btnUpper_Click(object sender, EventArgs e) // Upper Lower
        {
            txtResult2.Text = txtStr2.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            txtResult2.Text = txtStr2.Text.ToLower();
        }

        #endregion

        #region Inheritance
       
        private void btnTest3_Click(object sender, EventArgs e) // Inheritance
        {
            ParendClass p = new ParendClass();
            p.sayHello();
        }

        #endregion

        #region Polymorphism

        private void btnTest4_Click(object sender, EventArgs e)  // Polymorphism
        {
            B b = new B();
            b.Print();      //  class B (override)

            A a = (A)b;
            a.Print();      //  class B (override)

            C c = new C();
            c.Print();      //  class C (new)

            a = (A)c;
            a.Print();      //  class A (new)
        }

        #endregion

        #region Enum

        private void btnEnum_Click(object sender, EventArgs e) // Enum
        {
            Importance value = Importance.Critical;
            if (value == Importance.Trivial)
            {
                MessageBox.Show("Not true");
            }
            else if (value == Importance.Critical)
            {
                MessageBox.Show("True");
            }
            cmbEnum.DataSource = Enum.GetValues(typeof(E_b)); 
       }

        private void btnValue_Click(object sender, EventArgs e) // Enum
        {
            var nuturalNumbers = Enumerable.Range(1, 10);
            foreach (var n in nuturalNumbers)
            {
                MessageBox.Show(n.ToString());
            }
        }

        #endregion

        #region Generics

        private void btnGeneric_Click(object sender, EventArgs e) //Generics 
        {
            int x = 7, y = 12;
            MessageBox.Show(x.ToString() + " & " + y.ToString());
            Swapper<int>.Swap(ref x, ref y);
            MessageBox.Show(x.ToString() + " & " + y.ToString());

            string s = "Hello", t = "World";
            MessageBox.Show(s + " & " + t);
            Swapper<string>.Swap(ref s, ref t);
            MessageBox.Show(s + " & " + t);

            Customer c1 = new Customer()
            {
                name = "SSD"
            };
            Customer c2 = new Customer()
            {
                name = "OnTheRoad"
            };
            MessageBox.Show(c1.ToString() + " & " + c2.ToString());
            Swapper<Customer>.Swap(ref c1, ref c2);
            MessageBox.Show(c1.ToString() + " & " + c2.ToString());
        }

        #endregion

        #region Delegate

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            int[] values = new int[] { 1, 2, 3 };
            Util.Transform(values, Square);
            foreach ( int i in values)
                MessageBox.Show(i + " ");
        }
        static int Square(int x) { return x * x; }

        #endregion

        #region Lambda Queries

        private void btnLambda_Click(object sender, EventArgs e)
        {
            string[] names = { "Teerapong", "SSD", "OnTheRoad" };
            IEnumerable<string> query = names.Where(n => n.Contains("o"))
                                             .OrderBy(n => n.Length)
                                             .Select(n => n.ToUpper());
            foreach (string name in query)
                MessageBox.Show(name);
        }

        #endregion


    }
}

#region Delegate External

    public delegate int Transformer(int x);
    public class Util
    {
        public static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
            values[i] = t(values[i]);
            }
        }
    }

#endregion
  
#region Generics External

    class Swapper<T>
    {
        public static void Swap(ref T a, ref T b)
        {
        T temp = a;
        a = b;
        b = temp;
        }
    }

    class Customer
    {
        public string name { get; set; }
        public override string ToString()
        {
        return this.name;
        }
    }

#endregion

#region Enum External

        enum Importance
        {
            None,
            Trivial,
            Regular,
            Important,
            Critical
        };

        enum E_v
        {
            None,
            Hidden = 3,
            Visible = 4
        };

        enum E_b
        {
            None = 0,
            Cat = 1,
            Dog = 2
        };

#endregion

#region Polymorphism External

    class A
    {
        public virtual void Print()
        {
        MessageBox.Show("class A"); 
        }
    }

    class B : A
    {
        public override void Print()
        {
        MessageBox.Show("class B");
        }
    }

    class C : A
    {
        public new void Print()
        {
        MessageBox.Show("class C");
        }
    }

#endregion

#region Inheritance External

class ParendClass
    {
        public void sayHello()
        {
        MessageBox.Show("Hello SSD");
        }
    }

#endregion

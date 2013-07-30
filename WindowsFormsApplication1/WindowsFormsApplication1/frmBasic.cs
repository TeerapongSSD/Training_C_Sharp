using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void btnLambda1_Click(object sender, EventArgs e)
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            foreach(string name in query)
                MessageBox.Show(name);
        }


        #endregion

        #region Linq Queries

        private void btnLinq1_Click(object sender, EventArgs e)
        {
            string[] names = { "Tom", "Dick", "Harry" };
            IEnumerable<string> filteredNames = names.Where(n => n.Length >= 4);
            foreach (string name in filteredNames)
                MessageBox.Show(name);
        }

        #endregion

        #region CompreHension

        private void btnComprehension_Click(object sender, EventArgs e)
        {
            string[] names = { "Tom", "Disk", "Harry", "Mary", "Jay" };

            IEnumerable<string> query =
                from n in names
                where n.Contains("a")
                orderby n.Length
                select n.ToUpper(); 

            foreach (string name in query)
                MessageBox.Show(name);
        }

        #endregion

        #region Finally

        private void btnFinally_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;
            try
            {
                reader = File.OpenText("file.txt");
                if (reader.EndOfStream) return;
                MessageBox.Show(reader.ReadToEnd());
            }
            catch
            {
                throw;
            }
            finally
            {
                if (reader != null) reader.Dispose();
            }
        }

        #endregion

        #region Class

        private void btnClass_Click(object sender, EventArgs e)
        {
            Stock msft = new Stock("MSFT", 20, 1000);
            MessageBox.Show(msft.Worth.ToString());             //20000
            msft.CurrentPrice = 30;
            MessageBox.Show(msft.Worth.ToString());             //30000
            MessageBox.Show(msft.PurchasePrice.ToString());     //20
            MessageBox.Show(msft.CurrentPrice.ToString());      //30
            MessageBox.Show(msft.SharesOwned.ToString());       //1000
            MessageBox.Show(msft.Symbol.ToString());            //MSFT
            msft.Symbol = "MSFT EDIT";
            MessageBox.Show(msft.Symbol);                       //MSFT EDIT
        }

        #endregion    

        #region Inheritance

        private void btnTest3_Click(object sender, EventArgs e) // Inheritance
        {
            Asset asset = new Asset();
            asset.Name = "Pong";
            StockInher msft = new StockInher() { Name = "MSFT", PurchasePrice = 20, CurrentPrice = 30, SharesOwned = 1000 };
            House mansion = new House { Name = "McMansion", PurchasePrice = 200, CurrentPrice = 300, Mortgage = 2000 };
            
            MessageBox.Show(msft.Name + "," + msft.PurchasePrice + "," + msft.CurrentPrice + "," + msft.SharesOwned);
            MessageBox.Show(mansion.Name);
            mansion.Name = "Pong1";
            MessageBox.Show(asset.Name);
        }

        #endregion

        #region Interface

        private void btnInterface_Click(object sender, EventArgs e)
        {

            #region Original Interface

            //IEnumerator number = new Countdown();
            //while (number.MoveNext())
            //    MessageBox.Show(number.Current.ToString());

            #endregion

            #region Explicit Interface

            Widget w = new Widget();
            w.Foo();
            ((I1)w).Foo();
            ((I2)w).Foo();

            #endregion
                           
        }

        #endregion

        #region Anonymous Types

        public string Original;
        public string Vowelless;
        private void btnAnonymous_Click(object sender, EventArgs e)
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<frmBasic> temp =
                from n in names
                select new frmBasic
                {
                    Original = n,
                    Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "")
                                 .Replace("o", "").Replace("u", "")
                };
            IEnumerable<string> query = from item in temp
                                        where item.Vowelless.Length > 2
                                        select item.Original;
            foreach (string element in query)
                MessageBox.Show(element);
        }

        #endregion

 
    }//Class
}//NameSpace

    #region Interface External

        #region Original Interface

            public interface IEnumerator
            {
                bool MoveNext();
                object Current { get; }
            }

            internal class Countdown : IEnumerator
            {
                int count = 8;
                public bool MoveNext() { return count-- > 2; }
                public object Current { get { return count; } }
            }

        #endregion

        #region Explicit Interface

        interface I1 { void Foo();}
        interface I2 { int Foo();}

        public class Widget : I1, I2
        {
            public void Foo()
            {
                MessageBox.Show("Widget's implementation of I1.Foo");
            }

            int I2.Foo()
            {
                MessageBox.Show("widget's implementation of I2.Foo");
                return 42;
            }
        }

        #endregion

      
       
    #endregion

    #region Inheritance External

        public class Asset
        {
        public string Name{get; set;}
        public decimal PurchasePrice, CurrentPrice;
        }

        public class StockInher : Asset
        {
        public long SharesOwned;
        }

        public class House : Asset
        {
        public decimal Mortgage;
        }

    #endregion

    #region Class External

    public class Stock
    {
    string symbol;
    decimal purchasePrice, currentPrice;
    long sharesOwned;

        public Stock(string symbol, decimal purchasePrice, long sharesOwned)
        {
        this.symbol = symbol;
        this.purchasePrice = currentPrice = purchasePrice;
        this.sharesOwned = sharesOwned;
        }

        public decimal CurrentPrice
        { get { return currentPrice; } set { currentPrice = value; } }

        public string Symbol
        { get { return symbol; } set { symbol = value; } }

        public decimal PurchasePrice 
        { get { return purchasePrice; } }

        public long SharesOwned
        { get { return sharesOwned; } }

        public decimal Worth
        { get { return CurrentPrice * SharesOwned; } }
    }

#endregion

    #region Delegate External

    public delegate int Transformer(int x);
    public class Util
    {
        public static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
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



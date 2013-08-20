using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace GofPattern
{
    public partial class frmLinq : Form
    {
        public string DeptName { get; set; }
        public frmLinq()
        {
            InitializeComponent();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] numbers = { 1, 2, 3, 4, 5};

            bool AnyTest = numbers.Any(w => w == 1);
            bool AllTest = numbers.All(n => n % 2 == 1);

            listBox1.Items.Add("Any : " + AnyTest);
            listBox1.Items.Add("All : " + AllTest);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] numbers = { 1, 2, 3, 5, 5 };

            int TestCount = numbers.Distinct().Count();
            int TestSum = numbers.Sum();

            listBox1.Items.Add("Count : " + TestCount);
            listBox1.Items.Add("Sum : " + TestSum);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] numbers = { 1,2,3,4,5,6,7,8,9 };

            int TestMax = numbers.Max();
            int TestMin = numbers.Min();

            listBox1.Items.Add("Max : " + TestMax);
            listBox1.Items.Add("Min : " + TestMin);

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] numbers = { 9,8,7,6,5,4,3,2,1 };

            var TestSkip = numbers.Skip(2);
            var TestTake = numbers.Take(2);

            foreach (var n in TestSkip)
            {
                listBox1.Items.Add("Skip(2) : " + n);
            } 
            
            foreach (var n in TestTake)
            {
                listBox1.Items.Add("Take(2) : " + n);
            }
        }

        private void btnSkipWhile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] numbers = { 1,2,3,4,5,6,7,8,9 };

            var TestSkip = numbers.SkipWhile(n => n % 4 != 0);
            var TestTake = numbers.TakeWhile(n => n < 5);

            foreach (var n in TestSkip)
            {
                listBox1.Items.Add("SkipWhile(4) : " + n);
            }
            foreach (var n in TestTake)
            {
                listBox1.Items.Add("TakeWhile(5) : " + n);
            } 
  
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            System.Collections.ArrayList TestCast = new System.Collections.ArrayList();
            TestCast.Add("Test1");
            TestCast.Add("Test2");
            TestCast.Add("Test3");

            IEnumerable<string> query =
                TestCast.Cast<string>().OrderBy(n => n).Select(n => n); 
            foreach (var n in query)
            {
                listBox1.Items.Add("Cast : " + n);
            }

            int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums = from n in numbers
                           select strings[n];

            foreach (var n in textNums)
            {
                listBox1.Items.Add("Select : " + n);
            } 
        }

        private void btnOf_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 0.0 };
            var doubles = numbers.OfType<double>();

            foreach (var d in doubles)
            {
                listBox1.Items.Add("Of Type : " + d);
            }

            int[] number = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            var lowNums =from n in number
                where n <= 2
                orderby n
                select n;

            foreach (var n in lowNums)
            {
                listBox1.Items.Add("Where : " + n);
            } 
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] scores = new int[] { 1, 2, 3, 4,5 };
              IEnumerable<int> scoreQuery =
                from score in scores
                where score > 3
                select score;

             foreach (var n in scoreQuery)
            {
                listBox1.Items.Add(n);
            }            
        }

     
    }
}

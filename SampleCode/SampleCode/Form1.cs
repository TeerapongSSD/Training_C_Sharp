using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

#region SampleCode

        private void btnEnum_Click(object sender, EventArgs e)
        {
            clearList();
            IEnumerable<int> result = from value in Enumerable.Range(1, 3)
                                      select value;
            foreach (var n in result)
            {
                lsvResult.Items.Add(n);
            }
        }         

        private void btnForeach_Click(object sender, EventArgs e)
        {
            clearList();
            string[] testName = { "Teerapong", "Tatiyaprapa" };
            foreach (var n in testName)
            {
                lsvResult.Items.Add(n);
            }
        }

        private void btnYield_Click(object sender, EventArgs e)
        {
            clearList();
            foreach (var n in testYield(2, 10))
            {
                lsvResult.Items.Add(n);            
            }
        }

        public static IEnumerable<int> testYield(int first, int second)
        {
            int count = 0;
            int result = 1;
            while (count < second)
            {
                result *= first;
                count++;
                yield return result;
            }
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            clearList();
            string[] testVar = { "Teerapong", "Tatiyaprapa", "SSD", "OnTheRoAd" };
            var varQuery = from q in testVar
                            where q.ToUpper().ToLower().Contains("a")
                            select q;
            foreach (var n in varQuery)
            {
                lsvResult.Items.Add(n);
            }
            lsvResult.Items.Add(ReturnValue(10).ToString());
        }

        public int ReturnValue(int var) // Button Var
        {
            var a = 10;
            return a * var;
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            clearList();
            var nuturalNumbers = Enumerable.Range(1, 101);
            string[] names = { "SSD", "OnTheRoad", "Terapong" };
            IEnumerable<string> query = names.Where(n => n.ToUpper().ToLower().Contains("o"))
                                             .OrderBy(n => n.Length)
                                             .Select(n => n.ToUpper());
            foreach (var n in query)
            {
                lsvResult.Items.Add(n);
            }
        }

#endregion

#region Generic Collection



        private void btnList_Click(object sender, EventArgs e)
        {
            clearList();
            List<string> testList = new List<string>();
            testList.Add("Teerapong");
            testList.Add("Tatiyaprapa");
            testList.Add("SSD");

            List<int> testList1 = new List<int>();
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);

            foreach (var n in testList)
            {
            lsvResult.Items.Add(n);
            }
        } 

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            clearList();

            var letters = new HashSet<char>("teerapong");
            string result = "";

            foreach (char c in letters) result += c;
            lsvResult.Items.Add(result); result = "";

            lsvResult.Items.Add(letters.Contains('t')); 
            lsvResult.Items.Add(letters.Contains('z'));    

            letters = new HashSet<char>("teerapong");
            letters.IntersectWith("aeiou");
            foreach (char c in letters) result += c;
            lsvResult.Items.Add(result); result = "";

            letters = new HashSet<char>("teerapong");
            letters.ExceptWith("aeiou");
            foreach (char c in letters) result += c;
            lsvResult.Items.Add(result); result = "";

            letters = new HashSet<char>("teerapong");
            letters.SymmetricExceptWith("teerapongs" );
            foreach (char c in letters) result += c;
            lsvResult.Items.Add(result); result = "";

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for (var i = 1; i <= 5; i++)
            {
                first.Add(5 * i);
            }
            for (var j = 1; j <= 5; j++)
            {
                second.Add(10 * j);
            }
            lsvResult.Items.Add("The table of 5 is:");
            foreach (var n in first)
            {
                lsvResult.Items.Add(n);
            }
            lsvResult.Items.Add("The table of 10 is:");
            foreach (var n in second)
            {
                lsvResult.Items.Add(n);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            clearList();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Teerapong", 17);
            dict.Add("SSD", 5);

            foreach (KeyValuePair<string, int> n in dict)
            {
                lsvResult.Items.Add(n.Key.ToString());
            }
            if (dict.ContainsKey("Teerapong"))
            {
                var value = dict["Teerapong"];
                lsvResult.Items.Add(value);
            }      
            if (!dict.ContainsKey("OnTheRoad"))
            {
                lsvResult.Items.Add(false);
            }      
        }

#endregion


        private void clearList()
        {
            lsvResult.Items.Clear();
        }    

    }     


}

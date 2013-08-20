using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GofPattern
{
    public partial class frmGof : Form
    {
        public frmGof()
        {
            InitializeComponent();
        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            Singleton data1 = Singleton.GetInstance();
            Singleton data2 = Singleton.GetInstance();
            StateA data3 = new StateA();
            MessageBox.Show((data1 == data2).ToString());   
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            AbstractClass aA = new ClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ClassB();
            aB.TemplateMethod();
        }

        private void btnComposite_Click(object sender, EventArgs e)
        {
            CompositeSSD Test1 = new CompositeSSD("Mr.Test1", 1);
            CompositeOntheRoad Test2 = new CompositeOntheRoad("Mr.Test2", 2);
            CompositeOntheRoad Test3 = new CompositeOntheRoad("Mr.Test3", 3);
            CompositeOntheRoad Test4 = new CompositeOntheRoad("Mr.Test4", 4);
            CompositeSSD Test5 = new CompositeSSD("Mr.Test5", 5);
         
            Test2.AddSubordinate(Test1);  
            Test3.AddSubordinate(Test2); 
            Test3.AddSubordinate(Test4);
            Test4.AddSubordinate(Test5);

            if (Test3 is IEmployee)
            {
                (Test3 as IEmployee).ShowNumber();
            }
        }

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            A Ontheroad = new A();
            CompanyName OntheroadBand = Ontheroad.GetBread(CompanyBase.OntheRoad);
            OntheroadBand.Bake();

            B Ssd = new B();
            CompanyName SsdBread = Ssd.GetBread(CompanyBase.SSD);
            SsdBread.Bake();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            Context test = new Context(new StateA());
            test.Request();
            test.Request();
            test.Request();
        }

        private void frmGof_Load(object sender, EventArgs e)
        {

        }
    }

    # region Singleton

    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    #endregion

    #region Templete Method

    abstract class AbstractClass
    {
        public abstract void Test1();
        public abstract void Test2();

        public void TemplateMethod()
        {
            Test1();
            Test2();
        }
    }

    class ClassA : AbstractClass
    {
        public override void Test1()
        {
            MessageBox.Show("ClassA.Test1");
        }
        public override void Test2()
        {
            MessageBox.Show("ClassA.Test2");
        }
    }

    class ClassB : AbstractClass
    {
        public override void Test1()
        {
            MessageBox.Show("ClassB.Test1");
        }
        public override void Test2()
        {
            MessageBox.Show("ClassB.Test2");
        }
    }

    #endregion

    #region Composite

    public interface IEmployee
    {
        void ShowNumber();
    }

    public class CompositeSSD : IEmployee
    {
        private string name;
        private int number;

        public CompositeSSD(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        void IEmployee.ShowNumber()
        {
            MessageBox.Show(name + " Show Number: " + number);
        }
    }

    public class CompositeOntheRoad : IEmployee
    {
        private string name;
        private int number;

        private List<IEmployee> subordinate = new List<IEmployee>();

        public CompositeOntheRoad(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        void IEmployee.ShowNumber()
        {
            MessageBox.Show(name + " Show Number: " + number);
            foreach (IEmployee i in subordinate)
                i.ShowNumber();
        }

        public void AddSubordinate(IEmployee employee)
        {
            subordinate.Add(employee);
        }
    }

    #endregion

    #region Abstract Factory

    public enum CompanyBase
    {
        OntheRoad,
        SSD,
    }

    public interface CompanyFactory
    {
        CompanyName GetBread(CompanyBase BreadBase);
    }

    public interface CompanyName
    {
        void Bake();
    }

    public class OntheRoad : CompanyName
    {
        public void Bake()
        {
            MessageBox.Show("OntheRoad");
        }
    }

    public class SSD : CompanyName
    {
        public void Bake()
        {
            MessageBox.Show("SSD");
        }
    }

    public class A : CompanyFactory
    {
        public CompanyName GetBread(CompanyBase CompName)
        {
            CompanyName vBread = null;
            switch (CompName)
            {
                case CompanyBase.OntheRoad:
                    vBread = new OntheRoad();
                    break;
                case CompanyBase.SSD:
                    vBread = new SSD();
                    break;
            }
            return vBread;
        }
    }

    public class B : CompanyFactory
    {
        public CompanyName GetBread(CompanyBase CompName)
        {
            CompanyName vBread = null;
            switch (CompName)
            {
                case CompanyBase.OntheRoad:
                    vBread = new OntheRoad();
                    break;
                case CompanyBase.SSD:
                    vBread = new SSD();
                    break;
            }
            return vBread;
        }
    }

    #endregion

    #region State

    abstract class State
    {
        public abstract void Handle(Context context);
    }

    class StateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateB();
        }
    }

    class StateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateA();
        }
    }

   class Context
    {
        private State state;
        public Context(State state)
        {
            this.State = state;
        }
        public State State
        {
            get { return state; }
            set
            {
                state = value;
                MessageBox.Show(state.GetType().Name);
            }
        }
        public void Request()
        {
            state.Handle(this);
        }
    }

    #endregion

}

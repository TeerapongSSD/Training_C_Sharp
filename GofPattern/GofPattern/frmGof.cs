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

        #region Singleton

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            Singleton data1 = Singleton.GetInstance();
            Singleton data2 = Singleton.GetInstance();
            StateA data3 = new StateA();
            MessageBox.Show((data1 == data2).ToString());
        }

        #endregion

        #region Template Method

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            AbstractClass aA = new ClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ClassB();
            aB.TemplateMethod();
        }

        #endregion

        #region Composite

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

        #endregion

        #region  Abstract Factory

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            A Ontheroad = new A();
            CompanyName OntheroadBand = Ontheroad.GetBread(CompanyBase.OntheRoad);
            OntheroadBand.Bake();

            B Ssd = new B();
            CompanyName SsdBread = Ssd.GetBread(CompanyBase.SSD);
            SsdBread.Bake();
        }

        #endregion

        #region State

        private void btnState_Click(object sender, EventArgs e)
        {
            Context test = new Context(new StateA());
            test.Request();
            test.Request();
            test.Request();
        }

        #endregion

        #region Iterator

        private void btnIterator_Click(object sender, EventArgs e)
        {
            foreach (var n in TestIterator(0, 10))
            {
                MessageBox.Show(n.ToString());
            }
        }

        public static System.Collections.Generic.IEnumerable<int> TestIterator(int Number1, int Number2)
        {
            for (var n = Number1; n <= Number2; n++)
            {
                if (n % 3 == 0)
                {
                    yield return n;
                }
            }
        }

        #endregion

        #region Factory

        private void btnFactory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                var position = Factory.Get(i);
                MessageBox.Show(position.Title);
            }
        }

        #endregion

        #region Facade

        private void btnFacade_Click(object sender, EventArgs e)
        {
            Facade facade = new Facade();
            facade.MethodOne();
            facade.MethodTwo();
        }

        #endregion

        #region Obsever

        private void btnObsever_Click(object sender, EventArgs e)
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            s.SubjectState = "ABC";
            s.Notify();

            //IBM ibm = new IBM("IBM", 120.00);
            //ibm.Attach(new Investor("Sorros"));
            //ibm.Attach(new Investor("Berkshire"));

            //// Fluctuating prices will notify investors
            //ibm.Price = 120.10;
            //ibm.Price = 121.00;

            // Wait for user
          
        }

        #endregion

    }

    # region Singleton Class

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

    #region Templete Method Class

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

    #region Composite Class

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

    #region Abstract Factory Class

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

    #region State Class

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

    #region Factory Class

   abstract class Position
   {
       public abstract string Title { get; }
   }

   class Manager : Position
   {
       public override string Title
       {
           get
           {
               return "Manager";
           }
       }
   }

   class Admin : Position
   {
       public override string Title
       {
           get
           {
               return "Admin";
           }
       }
   }

   class Programmer : Position
   {
       public override string Title
       {
           get
           {
               return "Programmer";
           }
       }
   }

   static class Factory
   {
       public static Position Get(int id)
       {
           switch (id)
           {
               case 0:
                   return new Manager();
               case 1:
                   return new Admin();
               default:
                   return new Programmer();
           }
       }
   }

   #endregion

   #region Facade Class

   class FacadeOne
   {
       public void MethodOne()
       {
           MessageBox.Show(" Facade One");
       }
   }

   class FacadeTwo
   {
       public void MethodTwo()
       {
           MessageBox.Show(" Facade Two");
       }
   }

   class FacadeThree
   {
       public void MethodThree()
       {
           MessageBox.Show(" Facade Three");
       }
   }

   class Facade
   {
       private FacadeOne _one;
       private FacadeTwo _two;
       private FacadeThree _three;

       public Facade()
       {
           _one = new FacadeOne();
           _two = new FacadeTwo();
           _three = new FacadeThree();
       }

       public void MethodOne()
       {
           MessageBox.Show(" MethodOne() ***** ");
           _one.MethodOne();
           _two.MethodTwo();
       }

       public void MethodTwo()
       {
           MessageBox.Show(" MethodTwo() ***** ");
           _two.MethodTwo();
           _three.MethodThree();
       }
   }

   #endregion

   #region Observer Class

   abstract class Subject
  {
    private List<Observer> _observers = new List<Observer>();
 
    public void Attach(Observer observer)
    {
      _observers.Add(observer);
    }
 
    public void Detach(Observer observer)
    {
      _observers.Remove(observer);
    }
 
    public void Notify()
    {
      foreach (Observer o in _observers)
      {
        o.Update();
      }
    }
  }
 
  class ConcreteSubject : Subject
  {
    private string _subjectState;
    public string SubjectState
    {
      get { return _subjectState; }
      set { _subjectState = value; }
    }
  }

  abstract class Observer
  {
    public abstract void Update();
  }

  class ConcreteObserver : Observer
  {
    private string _name;
    private string _observerState;
    private ConcreteSubject _subject;

    public ConcreteObserver(
      ConcreteSubject subject, string name)
    {
      this._subject = subject;
      this._name = name;
    }
 
    public override void Update()
    {
      _observerState = _subject.SubjectState;

      Console.WriteLine("Observer {0}'s new state is {1}",_name, _observerState);
      MessageBox.Show( _name , _observerState);
    }

    public ConcreteSubject Subject
    {
      get { return _subject; }
      set { _subject = value; }
    }
  }

   #endregion


  //// The 'ConcreteObserver' class
  //class Investor : IInvestor
  //{
  //    private string _name;
  //    private Stock _stock;
  //    public Investor(string name)
  //    {
  //        this._name = name;
  //    }
  //    public void Update(Stock stock)
  //    {
  //        Console.WriteLine("Notified {0} of {1}'s " +
  //          "change to {2:C}", _name, stock.Symbol, stock.Price);
  //    }
  //    public Stock Stock
  //    {
  //        get { return _stock; }
  //        set { _stock = value; }
  //    }
  //}

  //// The 'ConcreteSubject' class
  //class IBM : Stock
  //{
  //    public IBM(string symbol, double price) : base(symbol, price) { }
  //}

  //// The 'Observer' interface
  //interface IInvestor
  //{
  //    void Update(Stock stock);
  //}

  //// The 'Subject' abstract class
  //abstract class Stock
  //{
  //    private string _symbol;
  //    private double _price;
  //    private List<IInvestor> _investors = new List<IInvestor>();
  //    // Constructor
  //    public Stock(string symbol, double price)
  //    {
  //        this._symbol = symbol;
  //        this._price = price;
  //    }
  //    public void Attach(IInvestor investor)
  //    {
  //        _investors.Add(investor);
  //    }
  //    public void Detach(IInvestor investor)
  //    {
  //        _investors.Remove(investor);
  //    }
  //    public void Notify()
  //    {
  //        foreach (IInvestor investor in _investors)
  //        {
  //            investor.Update(this);
  //        }
  //        //Console.WriteLine("");
  //    }
  
  //    public double Price
  //    {
  //        get { return _price; }
  //        set
  //        {
  //            if (_price != value)
  //            {
  //                _price = value;
  //                Notify();
  //            }
  //        }
  //    }
  
  //    public string Symbol
  //    {
  //        get { return _symbol; }
  //    }
  //}

}


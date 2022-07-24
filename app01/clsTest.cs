using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    #region "abstract"
    public class clsTest
    {
        // Observer o = new subject();
    }

    abstract class subject
    {
        private List<Observer> lst_Observer = new List<Observer>();
        public void notify()
        {
            string abc = "";
            //Observer o = new Observer();

            foreach (Observer o2 in lst_Observer)
            {
                o2.notify();
            }
        }
    }

    abstract class Observer
    {
        public string notify()
        {
            return "aaaaa";
        }
    }
    #endregion

    #region "interface 01"
    interface IMethods
    {
        void F();
        void G();
        void H();
        void I();
        //void O();
    }
    //class NBase : IMethods //Thieu method G,H,I
    //{
    //    public void F() { }

    //}
    class MBase : IMethods
    {
        void IMethods.F() { string s = "IMethods.F()"; } //OK
        //public void F() { }
        void IMethods.G() { }
        public void H() { }
        public void I() { }
    }
    class MDerived : MBase, IMethods
    {
        public void F() { string s = "MDerived.IMethods.F()"; }
        void IMethods.H() { }
    }
     class abc_cls
    {
        // Observer o = new subject();
    }
    #endregion



    #region "abstract 01"
    abstract class A
    {
        public abstract void F();
        //public abstract void Z();
    }
    abstract class B : A
    {
        public  void G() { }
        protected string pVar { get; set; }
        string pVar2 { get; set; }
        //public abstract void G() { } //error abstract not have body
        //public abstract void G(); // error because must have an implement in derived class
    }
    class C : B
    {
        public override void F()
        {
            // actual implementation of F
            this.pVar = "";
            
        }
    }

    //class D : A
    //{
    //    public override void Z()
    //    {
    //        // actual implementation of F
    //        this.pVar = "";

    //    }
    //}

    #endregion
    #region "abstract and interface"
    public interface IDoesCoolThings
    {
        void DoCool();
    }

    public abstract class AbstractWidget : IDoesCoolThings
    {
        //void IDoesCoolThings.DoCool() //error because of explicit interface implementation 
        //{
        //    Console.Write("I did something cool.");
        //}
        public void DoCool()
        {
            Console.Write("I did something cool.");
        }
    }

    public class RealWidget : AbstractWidget
    {

    }
    #endregion
}

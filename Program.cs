using System;

namespace polymorphism
{
    class A
    {
        public virtual void Method1()
        {
            System.Console.WriteLine("A class Method 1 called");
        }
        public virtual void Method2()
        {
            System.Console.WriteLine("A class Method 2 called");
        }
    }
    class B : A
    {
        public override void Method1()
        {
            System.Console.WriteLine("B class Method 1 called");
        }
        public override void Method2()
        {
            System.Console.WriteLine("B class Method 2 called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the A class Methods 

            /* A aObj can be read as 
            <datatype> <variable_name> = value
            int i = 10;
            The A() will be store in aObj as per above example
            */
            A aObj = new A();
            aObj.Method1();
            aObj.Method2();

            System.Console.WriteLine("------------------------------");

            /*This will work as the base can hold the reference of child class*/
            A bObj = new B();
            bObj.Method1();
            bObj.Method2();
        }
    }
}

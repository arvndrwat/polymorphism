using System;

namespace polymorphism
{
    class A
    {
        public void Method1()
        {
            System.Console.WriteLine("A class Method 1 called");
        }
        public void Method2()
        {
            System.Console.WriteLine("A class Method 2 called");
        }
    }
    class B : A
    {
        public void Method1()
        {
            System.Console.WriteLine("B class Method 1 called");
        }
        public void Method2()
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
            The A() methods will be store in aObj as per above example
            */
            A aObj = new A();
            aObj.Method1();
            aObj.Method2();


            B bObj = new B();
            bObj.Method1();
            bObj.Method2();
        }
    }
}

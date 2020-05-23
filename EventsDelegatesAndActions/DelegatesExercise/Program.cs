using System;
using System.Security.Cryptography;

namespace DelegatesExercise
{
    class Program
    {
        /* To create delegates: 
        1- Create the delegate itself.
        2- Create the handling method.
        3- Pass the handling method to the delegate.
        4- Invoke the delegate.
         */

        // 1- Creating the delegate
        public delegate void TestDelegateHandler(int param1, string param2);

        // 2- Creating the Handling method
        public static void TestMethod1(int number, string name)
        {
            Console.WriteLine("The delegate with TestMethod1 is working with number: {0} and name: {1}", number, name);
        }

        public static void TestMethod2(int number, string name)
        {
            Console.WriteLine("The delegate with TestMethod2 is working with number: {0} and name: {1}", number, name);
        }

        public static void DoWork(TestDelegateHandler testDelegateHandler)
        {
            testDelegateHandler(14, "Thiery Henry!");
            testDelegateHandler(34, "Granit Xhaka!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 3- Passing the handling method to the delegate
            TestDelegateHandler testDelegateHandler = new TestDelegateHandler(TestMethod1);
            TestDelegateHandler testDelegateHandler2 = new TestDelegateHandler(TestMethod2);

            // 4- Invoking the delegate
            DoWork(testDelegateHandler);
            DoWork(testDelegateHandler2);

            Console.Read();
        }
    }
}

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}

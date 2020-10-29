using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 100;
            string test = "Hello";
            Boolean new_test = false;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            long myNum_Long = 15000000000L;
            double myNum_Double = 19.99D;
            Console.WriteLine(myNum);
            Console.WriteLine(test);
            Console.WriteLine(new_test);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.Write(myNum + myLetter + " " + test +myDoubleNum);
            Console.WriteLine(myNum_Long);
            Console.WriteLine(myNum_Double);

        }
    }
}

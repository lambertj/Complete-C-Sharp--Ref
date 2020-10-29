using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            string txt_next = "Hello World";
            Console.WriteLine(txt_next.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt_next.ToLower());   // Outputs "hello world"
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);
            string name_new = string.Concat(firstName, lastName);
            Console.WriteLine(name_new);
            string name_name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name_name);
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
        }
    }
}

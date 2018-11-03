using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {   //Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
            int a = 5;
            int b = 10;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0} b={1}", a, b);
            Console.ReadLine();
        }
    }
}

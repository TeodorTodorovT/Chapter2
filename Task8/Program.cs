using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {   //task Declare two variables of type string and assign them values "Hello" and "World". Declare a variable of type object and assign to it the value obtained of concatenation of the two variables of type string (do not miss the space in the middle). Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
            string str1 = "Hello";
            string str2 = "World!";
            object obj = str1 + " " + str2;
            string str3 = obj.ToString();
            //Console.WriteLine(str3);
            //Console.ReadLine();
        }
    }
}

using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {   // Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign to this variable the value obtained of concatenation of the two string variables (add space if necessary). Print the variable of type object.
            string str1 = "Hello";
            string str2 = "World!";
            object obj = str1 + " " + str2;
            Console.WriteLine(obj);
            Console.ReadLine();
        }
    }
}

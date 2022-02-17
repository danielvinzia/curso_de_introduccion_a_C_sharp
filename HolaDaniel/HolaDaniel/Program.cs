using System;

namespace HolaDaniel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Daniel!");

            int height = 178;
            int age = 32;
            string name = "Daniel Vinzia";
            string information = "The information you resquested is: \nUser name: " + name 
                + "\nUser age: " + age + "\nUser height: " + height; 
            Console.WriteLine(information);
        }
    }
}

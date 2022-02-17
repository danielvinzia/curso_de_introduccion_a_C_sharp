using System;

namespace stringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What`s your name? Please Write your full name");
            String fullUserName = Console.ReadLine();

            Console.WriteLine("Hello " + fullUserName + ", Welcome to Dying");
        }
    }
}

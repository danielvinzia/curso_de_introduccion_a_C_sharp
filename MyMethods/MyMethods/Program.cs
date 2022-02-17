using System;

namespace MyMethods
{
    internal class Program
    {   
        public void IntegerAddition(int a, int b)
        {
            int addition = a + b;
            Console.WriteLine("El resultado es " + addition);
        }

        public int IntegerMultiplication(int a, int b)
        {
            int Multiplication = a * b;
            return Multiplication;
        }

        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.IntegerAddition(3, 6);

            int result = MyProgram.IntegerMultiplication(12, 2);
            Console.WriteLine("El resultado de la multiplicacion es " + result);

        }
    }
}

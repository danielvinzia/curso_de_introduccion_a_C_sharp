using System;

namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // este programa calcula el area de un rectangulo
            // rectangle area calculator

            // valores del rectangulo
            // rectangle values
            float sideA = 10.0f ;
            int sideB = 1 ;
            
            // la formula del area de un rectangulo es A*B
            // rectangle area formula is a*b
            float area = sideA * sideB;

            // + - / * %
            // ++ -- 

            Console.WriteLine("El area del rectangulo es: " + area);
        }
    }
}

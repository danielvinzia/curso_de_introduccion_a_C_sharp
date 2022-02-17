using System;

namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // este programa calcula el area de un rectangulo
            // valores del rectangulo
            Console.WriteLine("Ingresa el lado A del rectangulo, puede usar decimales");
            float sideA = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el lado B del rectangulo, puede usar decimales");
            float sideB = float.Parse(Console.ReadLine());

            // la formula del area de un rectangulo es A*B            
            float area = sideA * sideB;
            // + - / * %
            // ++ -- 
            Console.WriteLine("El area del rectangulo es: " + area);
        }
    }
}

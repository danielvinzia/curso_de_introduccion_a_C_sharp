using System;

namespace SentenciaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe que tipo de gaseosa quieres: ");
            Console.WriteLine("cola, sprite, fanta, pepsi");
            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "cola":
                    Console.WriteLine("Coca cola - $2 USD");
                    break;
                case "sprite":
                    Console.WriteLine("Sprite - $1 USD");
                    break;
                case "fanta":
                    Console.WriteLine("Fanta - $1.5 USD");
                    break;
                case "pepsi":
                    Console.WriteLine("Pepsi - $1.8 USD");
                    break;
                default:
                    Console.WriteLine("ERROR: Por favor ingrese una opcion valida");
                    break;
            }
        }
    }
}

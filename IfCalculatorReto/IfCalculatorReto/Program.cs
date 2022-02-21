using System;

namespace IfCalculatorReto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Kolo Calculator!");
            Console.WriteLine("selecciona tu opcion de acuerdo a que operacion quieres realizar");
            Console.WriteLine("Opcion 1, SUMA");
            Console.WriteLine("Opcion 2, RESTA");
            Console.WriteLine("Opcion 3, MULTIPLICACION");
            Console.WriteLine("Opcion 4, DIVISION");
            Console.WriteLine("Opcion 5, RAIZ CUADRADA");
            Console.WriteLine("Opcion 6, EXPONENTE CUADRADO");

            int opcion = int.Parse(Console.ReadLine());
            if (opcion < 1 || opcion > 6)
            {
                Console.WriteLine("Opcion incorrecta");
            }
            // SUMA
            if (opcion == 1)
            {
                Console.WriteLine("ingresa el primer numero");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("ingresa el segundo numero");
                float b = float.Parse(Console.ReadLine());
                float result = a + b;
                string aa = a.ToString();
                string bb = b.ToString();
                string resultt = result.ToString();
                Console.WriteLine($"El resultado de sumar " + aa + " y " + bb + " es " + resultt);
            }
            // RESTA
            if (opcion == 2)
            {
                Console.WriteLine("ingresa el primer numero");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("ingresa el segundo numero");
                float b = float.Parse(Console.ReadLine());
                float result = a - b;
                string aa = a.ToString();
                string bb = b.ToString();
                string resultt = result.ToString();
                Console.WriteLine($"El resultado de restar " + aa + " y " + bb + " es " + resultt);
            }
            // MULTIPLICACION
            if (opcion == 3)
            {
                Console.WriteLine("ingresa el primer numero");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("ingresa el segundo numero");
                float b = float.Parse(Console.ReadLine());
                float result = a * b;
                string aa = a.ToString();
                string bb = b.ToString();
                string resultt = result.ToString();
                Console.WriteLine($"El resultado de multiplicar " + aa + " y " + bb + " es " + resultt);
            }
            // DIVISION
            if (opcion == 4)
            {
                Console.WriteLine("ingresa el primer numero");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("ingresa el segundo numero");
                float b = float.Parse(Console.ReadLine());
                float result = a / b;
                string aa = a.ToString();
                string bb = b.ToString();
                string resultt = result.ToString();
                Console.WriteLine($"El resultado de dividir " + aa + " y " + bb + " es " + resultt);
            }
            // RAIZ CUADRADA
            if (opcion == 5)
            {
                Console.WriteLine("ingresa un numero");
                double a = double.Parse(Console.ReadLine());
                double result = Math.Sqrt(a);
                string aa = a.ToString();                
                string resultt = result.ToString();
                Console.WriteLine($"El resultado de la raiz cuadrada de " + aa + " es " + resultt);
            }
            // EXPONENTE CUADRADO
            if (opcion == 6)
            {
                Console.WriteLine("ingresa un numero");
                double a = double.Parse(Console.ReadLine());
                double result = Math.Pow(a, 2);
                string aa = a.ToString();
                string resultt = result.ToString();
                Console.WriteLine($"El resultado de la potencia al cuadrado de " + aa + " es " + resultt);
            }

        }
    }
}

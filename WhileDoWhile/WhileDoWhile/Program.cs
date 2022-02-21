using System;

namespace WhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHILE
            /*
            bool continuarSoftwareExecution = true;
            while (continuarSoftwareExecution == true)
            {
                Console.Write("Desea continuar la ejecucion?, escribe 1 por SI, escribe 0 por NO\n");
                int keepGoing = Convert.ToInt16(Console.ReadLine());
                if (keepGoing == 1)
                {
                    Console.WriteLine("el programa sigue en ejecucion");
                    continuarSoftwareExecution = true;
                }
                else if (keepGoing == 0)
                {
                    Console.WriteLine("el programa se detendra");
                    continuarSoftwareExecution = false;
                }
                else
                {
                    Console.WriteLine("opcion invalida, intenta de nuevo");
                    continuarSoftwareExecution = true;
                }     
            }
            */
            // DO WHILE
            bool continuarSoftwareExecution = false;
            do
            {
                Console.Write("Desea continuar la ejecucion?, escribe 1 por SI, escribe 0 por NO\n");
                int keepGoing = Convert.ToInt16(Console.ReadLine());
                if (keepGoing == 1)
                {
                    Console.WriteLine("el programa sigue en ejecucion");
                    continuarSoftwareExecution = true;
                }
                else if (keepGoing == 0)
                {
                    Console.WriteLine("el programa se detendra");
                    continuarSoftwareExecution = false;
                }
                else
                {
                    Console.WriteLine("opcion invalida, intenta de nuevo");
                    continuarSoftwareExecution = true;
                }
            } while (continuarSoftwareExecution == true);
        }
    }
}

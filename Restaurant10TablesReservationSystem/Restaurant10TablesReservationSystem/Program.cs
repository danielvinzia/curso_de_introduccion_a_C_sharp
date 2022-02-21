using System;

/*
 * 1. Validad si es usuario existente o si se debe registrar, y generar un sistema de registro o login
 * 2. el programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe.
 * 3. el programa debe repetirse hasta que se registren las 10 personas
 */

namespace Restaurant10TablesReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] { "", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 0;
            bool userType;
            Console.WriteLine("Bienvenido al restautante de Kolo, el mejor de todos!!!");
            while (arrayCurrentIndex < 10)
            {
                /*if(arrayCurrentIndex == 10)
                {
                    Console.WriteLine("el restaurante esta lleno, intente en otro momento");
                    Environment.Exit(0);
                }*/
                Console.WriteLine("\n \nEres tu un usuario registrado?, escribe 'true' eres usuario, escribe 'false' para registrarte");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hola usuario registrado, entra tu nombre de usuario");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("El usuario buscado es {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("Usuario no encontrado, intentalo de nuevo o registrate");
                    }
                    else
                    {
                        Console.WriteLine("Bienvenido {0}, es un placer tenerte de nuevo en nuestro restaurante", userNames[index]);
                    }
                }
                else if (userType == false)
                {
                    Console.WriteLine("por favor ingrese un nuevo nombre de usuario");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("te has registrado exitosamente\n" + 
                        "tu nombre de usuario es {0}", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("el restaurante esta lleno, intente en otro momento\n estos son los comensales que hay para la cena:");
            int auxIndex = 0;
            foreach (string element in userNames)
            {
                Console.WriteLine("numero de usuario {0} y el nombre es:{1}", auxIndex+1, userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}

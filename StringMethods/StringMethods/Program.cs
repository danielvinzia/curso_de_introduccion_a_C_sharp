using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ClassTopic = "Metodos de Strings";
            string School = "Kolo Academy";
            Console.WriteLine("Estoy aprendiendo en la clase de " + ClassTopic + " en "
                + School + ".");

            string SchoolClone = School.Clone().ToString();
            Console.WriteLine(SchoolClone);

            Console.WriteLine(ClassTopic.CompareTo(School));
            Console.WriteLine(School.CompareTo(SchoolClone));

            Console.WriteLine(School.Contains("olo"));

            Console.WriteLine(School.EndsWith("my"));

            Console.WriteLine(School.StartsWith("Ko"));

            Console.WriteLine(School.Equals(SchoolClone));

            Console.WriteLine(School.IndexOf("e"));

            Console.WriteLine(ClassTopic.ToLower());
            Console.WriteLine(ClassTopic.ToUpper());

            Console.WriteLine(School.Insert(12, " es educacion de LUJO"));

            Console.WriteLine(ClassTopic.LastIndexOf("s"));

            Console.WriteLine(ClassTopic.Remove(6));

            Console.WriteLine(ClassTopic.Replace("s", "z"));

            string[] split = ClassTopic.Split(new char[] { 's' });
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(ClassTopic.Substring(2,10));

            School.ToCharArray();

            string TextWithSpace = " hola, habia espacios al principio y al final ";
            Console.WriteLine(TextWithSpace.Trim());
        }
    }
}

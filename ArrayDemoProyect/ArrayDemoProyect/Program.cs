// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Bienvenido a la Cafeteria!");

string[] coffeeTypes;
float[] coffeePrices;

coffeeTypes = new string[] { "Expresso", "Largo", "Filtrado", "Latte" };
coffeePrices = new float[] {  1.2f,        1.5f,      5f,       5.5f};

coffeeTypes[1] = "Lungo";
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(coffeeTypes[i] + " coffee $" + coffeePrices[i]);
}

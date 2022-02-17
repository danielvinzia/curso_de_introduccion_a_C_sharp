// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> tacoShoppingList = new List<string>();

tacoShoppingList.Add("cinco tacos de suadero");
tacoShoppingList.Add("cuatro tacos de tripa");
tacoShoppingList.Add("cinco tacos de pastor");
tacoShoppingList.Add("cuatro coca cola");

for(int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

//tacoShoppingList.Remove("cinco tacos de suadero");
tacoShoppingList.RemoveAt(0);

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}
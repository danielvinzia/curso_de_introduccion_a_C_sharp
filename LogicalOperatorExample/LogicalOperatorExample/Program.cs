// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool value1 = true;
bool value2 = true;
bool value3 = false;

// && , || , !

bool result = value1 && value2 && value3;
Console.WriteLine("el resultado del AND logico es: " + result);

bool result2 = value1 || value2 || value3;
Console.WriteLine("el resultado del OR logico es: " + result2);

bool result3 = !value1; 
Console.WriteLine("el resultado del NOT logico es: " + result3);
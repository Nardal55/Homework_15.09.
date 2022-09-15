// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Write("Введите число a: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int max = number;
if (number1 > max) max = number1;
Console.WriteLine(max);




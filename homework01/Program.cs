// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Write("Введите число a: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int max = number;
int min = number;
if (number1 > max) max = number1;
if (number1 < min) min = number1;
Console.Write("Максимальное значение: ");Console.WriteLine(max);
Console.Write("Минимальное значение: ");Console.WriteLine(min);




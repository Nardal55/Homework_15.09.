﻿Console.Write("Введите число a: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
Console.WriteLine(max);
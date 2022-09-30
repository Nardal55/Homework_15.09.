Console.Write("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Degree(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    return result;
}

int degree = Degree(number1, number2);
Console.WriteLine($"Результат: {degree}");

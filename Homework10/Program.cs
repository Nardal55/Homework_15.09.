// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число  -> {number} ");
// int secondDigit = number / 10;
// int result = secondDigit % 10;
// Console.WriteLine(result);


int secondDigit(int num)
{
    int SecondDigit = num / 10;
    int result = SecondDigit % 10;
    return SecondDigit % 10;

}

int number = new Random().Next(100, 1000);
int result = secondDigit(number);

Console.WriteLine($"Случайное число  -> {number} ");

Console.WriteLine(result);

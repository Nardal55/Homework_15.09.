Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumAllNumber(int num)
{
    int counter = num;
    int arg = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
       arg = num - num % 10;
       result = result + (num - arg);
       num = num / 10; 
    }
    return result;
}
int sumAllNumber = SumAllNumber(number);
Console.WriteLine($"Сумма цифр равна: {sumAllNumber}");


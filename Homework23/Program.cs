Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void cube(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"|{count, 2} | {count * count * count, 3} |");
        count++;
    }

}
if (num > 0) cube(num);
else Console.WriteLine("Введен неправильное число");
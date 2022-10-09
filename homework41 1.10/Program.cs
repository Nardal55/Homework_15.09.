Console.Write($"Введи количество чисел: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] aboveZeroNumbers = new int[numbers];

void EntryNumbers(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        aboveZeroNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int CountNumbersMoreZero(int[] aboveZeroNumbers)

{
    int count = 0;
    for (int i = 0; i < aboveZeroNumbers.Length; i++)
    {
        if (aboveZeroNumbers[i] > 0) count += 1;
    }
    return count;
}

EntryNumbers(numbers);
int countNumbersMoreZero = CountNumbersMoreZero(aboveZeroNumbers);
Console.WriteLine($"Чисел больше нуля(0) -> {countNumbersMoreZero}");


int[] CreateArrrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int SumOddArray (int[]array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sumOdd = sumOdd + array[i];
    }
    return sumOdd;
}


int[] arr = CreateArrrayRndInt(5, -10 , 10);
PrintArray(arr);
int sumOdd = SumOddArray(arr);
Console.WriteLine($"Сумма чисел нечетных элементов: -> {sumOdd}");


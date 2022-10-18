Console.WriteLine("Введите неотрицательное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int FunctionAkkermana (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM >= 0 && numN == 0) return FunctionAkkermana(numM - 1, 1);
    if (numM > 0 && numN > 0) return FunctionAkkermana(numM - 1, FunctionAkkermana(numM, numN - 1));
return FunctionAkkermana(numM, numN);
}

Console.WriteLine($"Функция Аккермана чисел A({numberM},{numberN}) = {FunctionAkkermana(numberM, numberN)}");


Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
SummaFromMtoN(numberM, numberN, 0);

void SummaFromMtoN(int numM, int numN, int sumMN)
{
    if (numM > numN)
    {
        Console.WriteLine($"сумма чисел в промежутке от M до N = {sumMN}");
        return;
    }
    sumMN = sumMN + (numM++);
    SummaFromMtoN(numM, numN, sumMN);

    // не могу реализовать чтобы было наоборот когда вводим к примеру 7 и 3
    // if (numM < numN)
    // {
    //     Console.WriteLine($"сумма чисел в промежутке от M до N = {sumMN}"); 
            // return;

    // }
    // sumMN = sumMN + (numN++);
    // SummaFromMtoN(numM, numN, sumMN);
}
    
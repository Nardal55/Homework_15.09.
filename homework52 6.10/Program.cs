int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(1); i++) 
    {
        for (int j = 0; j < matrix.GetLength(0); j++)  
        {
            matrix[j, i] = rnd.Next(min, max + 1);  
        }
    }
    return matrix;

}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
int count = 1;
void AverageColumnArithmetic(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {   
            result += matrix[j, i];
        }
        Console.WriteLine($"среднее арифметическое в столбце {count} = {Math.Round(result / matrix.GetLength(0), 2)} ");
        count++;
    }

}
int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
AverageColumnArithmetic(array2D);

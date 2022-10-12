﻿double[,] CreateMatrixRndInt(double rows, double columns)
{
    double[,] matrix = new double[3 ,4];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;  
        }
    }
    return matrix;

}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 6}");
            else Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine(" |");
    }
}
double[,] array2D = CreateMatrixRndInt(3, 4);
PrintMatrix(array2D);

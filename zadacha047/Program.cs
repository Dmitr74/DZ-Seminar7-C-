// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7   -2  -0,2
//  1  -3,3   8  -9,9
//  8   7,8 -7,1   9


Console.Clear();

double[,] FillMatrixRandom(int row, int column)
{
    double[,] arr = new double[row, column];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Random rnd = new Random();
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(rnd.NextDouble() + rnd.Next(10, 99),1);
        }
    }
    return arr;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + ";  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
PrintMatrix(FillMatrixRandom(row,column));


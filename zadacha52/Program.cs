// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

int[,] ArrayRandom(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }

    }
    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

string Simple(int[,] matrix)
{
    double sum = 0;
    string result = String.Empty;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = 0;
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];
        }
        result = result + $"{sum / matrix.GetLength(0)}; ";
    }
    return result;
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = ArrayRandom(row, column);
PrintMatrix(matrix);
Console.Write("Среднее значение столбца: ");
Console.Write(Simple(matrix));

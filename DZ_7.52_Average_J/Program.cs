// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] ArrayMxN(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rnd.Next(-10, 11);
        }
    }
    return matrix;
}

void PrintArrayMxN(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageColum(int[,] matrix)
{
    int length = matrix.GetLength(1);
    int[] arrayAverage = new int[length];

    double aver = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        aver = sum / (matrix.GetLength(0));
        System.Console.WriteLine($"Среднее арифметическое столбца №{j+1} = {string.Join(", ", aver)} \t");
    }
}

int row = 2;
int column = 3;
int[,] matrix = ArrayMxN(row, column);

PrintArrayMxN(matrix);
AverageColum(matrix);

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
            matrix[i, j] = rnd.Next(-100, 101);
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
    int 
    for(j=0; j<matrix.GetLength(1); j++)
    {
        aver=aver
    }
    // if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1))
    // {
    //     System.Console.Write($"\nТакого числа в массиве нет");
    // }
    // else
    // {
    //     int M = matrix[x, y];
    //     System.Console.Write($"\nПозиция {x}{y} = {M}" + "\n");
    // }
}

int row = 5;
int column = 5;
int[,] matrix = ArrayMxN(row, column);

PrintArrayMxN(matrix);
NumberByPosition(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void NumberByPosition(int[,] matrix)
{
    System.Console.Write("Введите позицию X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите позицию Y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1))
    {
        System.Console.Write($"\nТакого числа в массиве нет");
    }
    else
    {
        int M = matrix[x, y];
        System.Console.Write($"\nПозиция {x}{y} = {M}" + "\n");
    }
}

int row = 5;
int column = 5;
int[,] matrix = ArrayMxN(row, column);

PrintArrayMxN(matrix);
NumberByPosition(matrix);
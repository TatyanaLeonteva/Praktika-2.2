// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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

int RowWithLowSum(int[,] matrix)
{
    int length = matrix.GetLength(0);
    int[] arraySums = new int[length];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        System.Console.WriteLine($"Сумма элементов строки №{i + 1} = \t {string.Join(", ", sum)} \t");
        arraySums[i] = sum;
    }
    int lowRow = 1;
    int minSum = arraySums[0];
    for (int i = 0; i < length; i++)
    {
        if (arraySums[i] < minSum)
        {
            lowRow = i+1;
            minSum = arraySums[i];
        }
    }
    return lowRow;
}

System.Console.Write("\nВведите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов, не равное кол-ву строк: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row == column)
{
    System.Console.WriteLine($"\nОшибка! Кол-во строк равно кол-ву столбцов.\n");
    return;
}

int[,] matrix = ArrayMxN(row, column);

PrintArrayMxN(matrix);
System.Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {RowWithLowSum(matrix)}"+"\n");

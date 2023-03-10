// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] ArrayMxN(int row, int column)
{
    double[,] matrix = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() +rnd.Next(-10,10),2);
        }
    }
    return matrix;
}

void PrintArrayMxN(double[,] matrix)
{
    Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = ArrayMxN(row, column);
PrintArrayMxN(matrix);
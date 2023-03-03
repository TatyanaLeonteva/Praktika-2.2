// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] FillMatrixWithSumIndex(int M, int N)
{
    int[,] matrix = new int[M, N];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
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

System.Console.Write("Введите кол-во строк: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithSumIndex(M, N);
PrintMatrix(matrix);

// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5

// int[,] FillMatrixWithSumIndex(int M, int N)
// {
//     int[,] matrix = new int[M, N];

//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = i+j;
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// System.Console.Write("Введите кол-во строк: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите кол-во столбцов: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithSumIndex(M, N);
// PrintMatrix(matrix);

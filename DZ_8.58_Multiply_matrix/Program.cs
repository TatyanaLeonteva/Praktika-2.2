// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ArrayMxN(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
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

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixMulty = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixMulty.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMulty.GetLength(1); j++)
        {
            
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixMulty[i,j] = matrixMulty[i,j]  + matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixMulty;
}

System.Console.Write("\nВведите кол-во строк матрицы A: ");
int rowsAmatrix = Convert.ToInt32(Console.ReadLine());
System.Console.Write(
    "Введите кол-во столбцов матрицы A и количество строк матрицы B (они равны): "
);
int columnsAmatrix = Convert.ToInt32(Console.ReadLine());
int rowsBmatrix = columnsAmatrix;
System.Console.Write("Введите кол-во столбцов B матрицы: ");
int columnsBmatrix = Convert.ToInt32(Console.ReadLine());

if (rowsAmatrix == 0 || columnsAmatrix == 0 || columnsBmatrix == 0)
{
    System.Console.WriteLine($"\nОшибка! Кол-во строк или столбцов не может быть меньше 1.\n");
    return;
}

int[,] matrixA = ArrayMxN(rowsAmatrix, columnsAmatrix);
int[,] matrixB = ArrayMxN(rowsBmatrix, columnsBmatrix);

System.Console.Write($"\nМатрица А:");
PrintArrayMxN(matrixA);
System.Console.Write($"\nМатрица B:");
PrintArrayMxN(matrixB);

System.Console.Write($"\nРезультирующая матрица:");
PrintArrayMxN(MultiplicationMatrix(matrixA, matrixB));

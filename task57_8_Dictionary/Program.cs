// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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

int[] FrequencyDictionary(int[,] matrix)
{
    int[] temp = new int[10];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[matrix[i, j]]++;
        }
    }
    return temp;
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);

System.Console.WriteLine($"\nИсходная матрица:");
PrintMatrix(matrix);
Console.WriteLine();

int[] indexArray = FrequencyDictionary(matrix);
for (int i = 0; i < indexArray.Length; i++)
{
    if (indexArray[i] != 0) // != - неравно // == - равно
    {
        Console.WriteLine($"Число {i} встретилось {indexArray[i]} раз");
    }
}

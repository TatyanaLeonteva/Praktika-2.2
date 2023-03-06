// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array8Elements(int length)
{
    int[] array = new int[length];
    
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

int length = 8;
int[] array8El = Array8Elements(length);
System.Console.WriteLine($"\nМассив из 8 элементов [{string.Join(", ", array8El)}]\n");
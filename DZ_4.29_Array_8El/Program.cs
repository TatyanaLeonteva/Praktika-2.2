// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array8Elements(int Name) 
// int - тип возвращаемого значения, [] - одномерный массив, [,] многомерный массив
// в круглых скобках - аргумент, то, что принимает: int - тип аргумента, Name - любое название
{
    int[] array = new int[Name];
    
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

int Name = 15;
int[] array8El = Array8Elements(Name);
System.Console.WriteLine($"\nМассив из 8 элементов [{string.Join(", ", array8El)}]\n");
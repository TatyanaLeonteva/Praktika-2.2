// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ArrayNumbers(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i=0; i< array.Length; i++)
    {
        if(array[i]>=0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int length = Convert.ToInt32(Console.ReadLine());

if (length < 0) 
{ 
    Console.WriteLine("Количество чисел должно быть больше 0");
}
else
{
    System.Console.WriteLine($"\nКол-во чисел больше нуля = {CountPositiveNumbers(ArrayNumbers(length))}" + "\n");
    // System.Console.WriteLine($"\n[{string.Join(", ", ArrayNumbers(length))}]" + "\n");
}

// Задача №22. Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Write("Введите число, больше 1: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < 2)
// {
//     Console.Write($"Введено неверное число ");
//     return;
// }
// else
// {
//     int i = 1;
//     double temp = 1;

//     while (i < N)
//     {
//         temp = Math.Pow(i, 2);
//         i++;
//         Console.Write($"{temp}, ");
//     }
//     temp = Math.Pow(i, 2);
//     Console.Write($"{temp}");
// }


Console.Write("Введите число, больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 2)
{
    Console.Write($"Введено неверное число ");
    return;
}
else
{
    for (int i = 1; i < N; i++)
    {
        System.Console.Write($"{Math.Pow(i, 2)}, ");
    }
    System.Console.Write($"{Math.Pow(N, 2)}");
}
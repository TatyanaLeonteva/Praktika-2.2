// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число, больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 2)
{
    Console.Write($"Введено неверное число ");
    return;
}
else
{
    int i = 0;
    while (i < N - 3)
    {
        i = i + 2;
        Console.Write($"{i}, ");
    }
    if (N % 2 == 0)
    {
        Console.Write($"{N}");
    }
    else
    {
        Console.Write($"{N - 1}");
    }
}

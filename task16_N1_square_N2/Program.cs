// Задача №16. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите число 1: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int N2 = Convert.ToInt32(Console.ReadLine());

if (N1 * N1 == N2 || N2 * N2 == N1)
{
    if (N1 > N2)
    {
        Console.WriteLine($"{N2} в квадрате = {N1}");
    }
    else
    {
        Console.WriteLine($"{N1} в квадрате = {N2}");
    }
}
else
{
    Console.WriteLine($"Нет");
}

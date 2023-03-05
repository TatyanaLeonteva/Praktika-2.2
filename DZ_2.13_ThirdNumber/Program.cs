// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > -100 && N < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if(Math.Abs(N)>999)
{
    while (Math.Abs(N) > 999)
    {
        N = N / 10;
    }
    int thirdNumber = Math.Abs(N) % 10;
    Console.WriteLine($"{thirdNumber}");
}
else
{
    int thirdNumber = Math.Abs(N) % 10;
    Console.WriteLine($"{thirdNumber}");
}

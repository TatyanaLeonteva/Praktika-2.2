// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigitsInNumber(int N)
{
    if (Math.Abs(N) == 0)
    {
        return 0;
    }
    return Math.Abs(N) % 10 + SumDigitsInNumber(Math.Abs(N) / 10);
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {N} = "+SumDigitsInNumber(N));


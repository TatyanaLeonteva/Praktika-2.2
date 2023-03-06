// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int M = Math.Abs(N);
int Sum = M%10;

for(int i=0; M/10>0; i++)
{
    Sum=Sum+M/10%10;
    M=M/10;
}
Console.WriteLine($"Сумма цифр числа {N} = {Sum}");
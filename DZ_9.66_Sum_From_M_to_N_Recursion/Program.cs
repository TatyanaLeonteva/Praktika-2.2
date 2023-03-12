// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersFromMtoN(int M, int N)
{
    if (M >= N)
    {
        return M;
    }
    return M + SumNumbersFromMtoN(M + 1, N);
}

System.Console.Write("Введите число N (max): ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число M (min): ");
int m = Convert.ToInt32(Console.ReadLine());

if (m >= n)
{
    System.Console.Write("Введите N (max) больше, чем M (min)");
}
else
{
    Console.WriteLine($"Сумма чисел от {m} до {n} = " + SumNumbersFromMtoN(m, n));
}

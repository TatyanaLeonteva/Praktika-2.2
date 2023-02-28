// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintFibToN(int number)
{
    System.Console.Write("0 1 ");
    int neighnour1 = 0;
    int neighnour2 = 1;
    int rez = 0;
    for (int i = 2; i < number; i++) // for (int i = 0; i < number-2; i++)
    {
        rez = neighnour1 + neighnour2;
        System.Console.Write($"{rez} ");
        neighnour1 = neighnour2;
        neighnour2 = rez;
    }
}

Console.WriteLine("Ввидите число: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintFibToN(N);

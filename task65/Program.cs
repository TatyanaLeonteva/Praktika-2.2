// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void RoadToN(int N, int M)
{
    if(N<M)
    {
        return;
    }
    RoadToN(N-1, M);
    System.Console.Write($"{N}  ");
}

System.Console.Write("Введите число N (max): ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число M (min): ");
int m = Convert.ToInt32(Console.ReadLine());

RoadToN(n, m);
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

static int Akkerman(int m, int n);
{
    if(n==0)
    {
        return m+1;
    }
    else if (n>0 && m==0)
    {
        return Akkerman(n-1, 1);
    }
    else if (n > 0 && m>0)
    {
        return Akkerman(n-1, Akkerman(n, m-1));
    }  
}

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

if (m <0 && n<0)
{
    System.Console.Write("Введите положительные натуральные числа");
}
else
{
    Console.WriteLine($" = " + Akkerman(N,M));
}

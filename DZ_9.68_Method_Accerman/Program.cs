// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (n > 0 && m>0)
    {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
    else if (m>0 && n==0)
    {
        return Akkerman(m-1, 1);
    }
    else
    {
        return n+1;
    } 
}

System.Console.Write("Введите число m для функции Аккермана A(m,n): ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число n для функции Аккермана A(m,n): ");
int N = Convert.ToInt32(Console.ReadLine());

if (M <0 && N<0)
{
    System.Console.WriteLine($"\nВведите положительные натуральные числа" +"\n");
}
else
{
    Console.WriteLine($"\nA({M},{N}) = " + Akkerman(M,N)+"\n");
}

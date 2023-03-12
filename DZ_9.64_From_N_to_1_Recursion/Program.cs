// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RoadToN(int temp, int N)
{
    if(N<=0)
    {
        System.Console.Write("Ошибка, введите число больше 0");
        return;
    }
    else if (temp > N)
    {
        return;
    }
    RoadToN(temp+1, N);
    System.Console.Write($"{temp} ");
}

System.Console.Write("Введите число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());

int temp = 1;
System.Console.Write($"Промежуток от {number} до 1:  " );
RoadToN(temp, number);
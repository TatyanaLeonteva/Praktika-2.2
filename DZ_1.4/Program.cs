// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int max2 = number2;

if(max2 < number3)
{
    max2 = number3;
}
else
{
    max2=number2;
}
if(max < max2)
{
    max = max2;
}
Console.WriteLine($"max={max}");

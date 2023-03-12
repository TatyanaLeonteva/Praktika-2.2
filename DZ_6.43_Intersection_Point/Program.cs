// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;
    return array;
}

Console.Write("Введите координату b1: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k1: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b2: ");
double B2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k2: ");
double K2 = Convert.ToDouble(Console.ReadLine());

if(K1==K2)
{
    System.Console.WriteLine($"\nЛинии параллельны"+"\n");
}
else
{
    System.Console.WriteLine($"\nТочка пересечения двух прямых \ny={K1}*x+{B1} \ny={K2}*x+{B2}: \n[{string.Join(", ", IntersectionPoint(B1, K1, B2, K2))}]"+"\n");
}
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int[] AiB()
{
    Console.Write("Введите число А: ");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите натуральную степень, в которую нужно возмести число: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int[] array={A,B};
    return array;
}

int InGrade(int[] array1)
{
    int temp=array1[0];
    for(int i=1; i<array1[1]; i++)
    {
        temp = temp * array1[0];
    }
    return temp;
}

System.Console.WriteLine(InGrade(AiB()));

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите натуральную степень, в которую нужно возмести число: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int temp = A;

// if (B <= 0)
// {
//     Console.Write($"\nНатуральная степень не может быть отрицательной или равной 0");
//     System.Console.WriteLine("\n");
//     return;
// }
// else
// {
//     for (int i = 2; i <= B; i++)
//     {
//         temp = temp * A;
//     }
//     System.Console.Write($"\n{A} в степени {B} = {temp}");
// }
// System.Console.WriteLine("\n");


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

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
    if(array1==B)
    {
        return;
    }

    int temp=array1[0];
    for(int i=1; i<array1[1]; i++)
    {
        temp = temp * array1[0];
    }
    return temp;
}


System.Console.WriteLine(InGrade(AiB()));

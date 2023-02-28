﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

double[] FillArrayWithRandomNumbers(int length)
{
double[] arr = new double [length];
Random rnd = new Random();
for(int i =0; i < arr.Length; i++)
    {
    arr[i] = rnd.Next(-100, 101);
    }
return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

double min = array[0];
double max = array[0];

for(int i = 1; i < array.Length; i++)
{
    if(max>array[i])
    {
        if(min<array[i])
        {}
        else
        min=array[i];
    }
    else
    max=array[i];
}
double diff=max-min;
System.Console.WriteLine($"Max = {max}, Min = {min}, diff = {diff}");

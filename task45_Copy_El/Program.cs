// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int[length];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 10);
}
return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", arr)}]");

int[] NewArray = new int[length];

System.Console.WriteLine($"[{string.Join(", ", NewArray)}]");

for (int i=0; i < length; i++)
{
    NewArray[i] = arr[i];
}

System.Console.WriteLine($"[{string.Join(", ", NewArray)}]");
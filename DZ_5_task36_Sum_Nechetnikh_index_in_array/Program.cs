// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int [length];
Random rnd = new Random();
for(int i =0; i < arr.Length; i++)
    {
    arr[i] = rnd.Next(-100, 101);
    }
return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

int SumOdd = 0;

for(int i = 1; i < array.Length; i=i+2)
{
    SumOdd=SumOdd+array[i];
}
System.Console.WriteLine($"Сумма нечётных = {SumOdd}");

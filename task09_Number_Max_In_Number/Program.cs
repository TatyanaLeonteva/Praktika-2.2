// Случайное число из отрезка 10-99 и показать наибольшую циру числа

int number = new Random().Next(10, 100);
Console.WriteLine($"Ваше случайное число: {number}");
int digit1 = number/10;
int digit2 = number%10;

if(digit1 > digit2)
{
    Console.Write($"Наибольшая цифра числа: {digit1}");
}
else if (digit2 > digit1)
{
    Console.Write($"Наибольшая цифра числа: {digit2}");
    }
else 
{
    Console.Write($"Числа равны");
}
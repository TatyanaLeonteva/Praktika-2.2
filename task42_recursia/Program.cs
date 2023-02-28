// Задача 42

void BinaryView(int number)
{
    if(number <=0)
    {
        return;
    }
    BinaryView(number/2);
    Console.Write(number%2);
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
BinaryView(number);
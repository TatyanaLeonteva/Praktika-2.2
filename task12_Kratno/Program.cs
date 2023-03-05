// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Write("Введите Number1: ");
int Number5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Number2: ");
int Number6 = Convert.ToInt32(Console.ReadLine());

int Div = Number6/Number5;

if(Div%10==0)
{
    Console.WriteLine($"Кратно");
}
else
{
Console.WriteLine($"Не кратно, остаток от деления {Div%10}");
}

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int mod = number1 % number2;
// if(mod == 0)
// {
// Console.Write("Кратно");
// }
// else
// {
// Console.Write($"Не кратно, остаток {mod}");
// }
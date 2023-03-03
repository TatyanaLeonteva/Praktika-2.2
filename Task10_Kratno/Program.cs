// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Write("Введите Number5: ");
int Number5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Number6: ");
int Number6 = Convert.ToInt32(Console.ReadLine());

int Div = Number6/Number5;

if(Div%10==0)
{
    Console.WriteLine($"Кратно");
}
else
{
Console.WriteLine($"Остаток от деления: {Div%10}");
}

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if( day==6 || day==7)
{
    Console.WriteLine($"Выходной");
}
else if(day>=6 || day<=0)
{
    Console.WriteLine($"Не существует");
}
else 
{
    Console.WriteLine($"Рабочий");
}
// Задача №18. Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Checked(int quarter)
{
    if (quarter >= 1 && quarter <= 4)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string[] quarters = { "x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0" };

int quarter = Promt("Введите четверть: ");

if (Checked(quarter))
{
    Console.Write(quarters[quarter - 1]);
}
else
{
    Console.Write("Неправильный номер четверти");
}

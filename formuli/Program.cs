double number = 5.321321321321;
double result1 = Math.Round(number, 2); // Округление
System.Console.WriteLine($"\n{result1} округление числа {number}");

double master = Math.Pow(number, 2); // Возведение в степень
System.Console.WriteLine($"{number} в степени 2 = {master}");

double number1 = Math.Sqrt(master); // квадратный корень
System.Console.WriteLine($"квадратный корень 25 = {number1}");

double result2 = Math.Round(Math.Sqrt(Math.Pow(number, 2)), 2);
System.Console.WriteLine($"\n{result2} это число {number}, возведённое в квадрат ({master}), из которого извлекли квадратный корень ({number1}) и округлили до 2х знаков\n");

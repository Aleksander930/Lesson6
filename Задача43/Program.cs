// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите b1: ");
double b1 = Convert.ToUInt32(Console.ReadLine());
System.Console.Write("Введите k1: ");
double b2 = Convert.ToUInt32(Console.ReadLine());
System.Console.Write("Введите b2: ");
double k1 = Convert.ToUInt32(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = Convert.ToUInt32(Console.ReadLine());
double x = (k1 - b1) / (b2 - k2);
double y = b2 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
System.Console.Write($" {x}, {y}");
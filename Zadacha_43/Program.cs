﻿// Задача 43
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = ((b2 - b1) / (k1 - k2));
double y = ((b2 - b1) / (k1 - k2)) * k1 + b1;
Console.WriteLine($"Координата Х = {x}");
Console.WriteLine($"Координата Y = {y}");
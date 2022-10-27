// Задача 50
Console.Write("Введите номер элемента по ширине массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер элемента по глубине массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
if (m > 4 || n > 3) Console.Write("Такого элемента в массиве нет");
else Console.Write($"{array[m - 1, n - 1]} ");

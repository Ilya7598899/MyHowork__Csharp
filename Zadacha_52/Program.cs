// Задача 52
int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
double sredn = 0;
double sum = 0;
Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < 4; i++)
{
    sum = 0;
    for (int j = 0; j < 3; j++)
    {
        sum = sum + array[j, i];
    }
    sredn = sum / 3;
    // Console.Write($"{Math.Round(sredn-sredn% 0.1, 1)} "); // оставление нужного количество знаков после запятой
    Console.Write($"{Math.Round(sredn, 1)} "); // округление
}
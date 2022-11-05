// Задача 56
int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[] summ;
summ = new int[4];
int min=0;
int StrokaMin = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        summ[i] = summ[i] + array[i, j];
    }
    Console.WriteLine($"Сумма {i+1} строки = {summ[i]}");
    
    if (i==0) min = summ[0];
    if (summ[i] < min)
    {
        min = summ[i];
        StrokaMin = i;
    }
        }
Console.WriteLine($"номер строки с наименьшей суммой элементов: {StrokaMin+1} строка");

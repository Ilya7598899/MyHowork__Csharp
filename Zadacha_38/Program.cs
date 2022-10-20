// Задача 38
double[] array = { 3, 7, 22, 2, 78 };
//array = new int[length];
//Random rand = new Random();
double rathnitsa = 0;
double min = 0;
double max = 0;
for (int i = 0; i < 5; i++)
{
    min = array[i];
    max = array[i];
    for (int j = 0; j < 5; j++)
    {

        if (array[j] < min) min = array[j]; 
        if (array[j] > max) max = array[j];
    }
}
rathnitsa = max - min;
Console.WriteLine("");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {rathnitsa}");
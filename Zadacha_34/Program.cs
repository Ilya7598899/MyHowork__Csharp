// Задача 34
int length = 4;
int[] array;
array = new int[length];
Random rand = new Random();
int sum = 0;
int a = 0;
for (int i = 0; i < length; i++)
{
    array[i] = rand.Next(100, 1000);
    a = array[i] % 2;
    Console.Write($"{array[i]} ");
    if (a == 0)
    {
        sum++;
    }
}
Console.WriteLine("");
Console.WriteLine($"Количество чётных чисел = {sum}");
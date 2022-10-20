// Задача 36
int length = 4;
int[] array;
array = new int[length];
Random rand = new Random();
int sum = 0;
int a = 0;
for (int i = 0; i < length; i++)
{
    array[i] = rand.Next(-99, 100);
    a = i % 2;
    Console.Write($"{array[i]} ");
    if (a != 0)
    {
        sum=sum+array[i];
    }
}
Console.WriteLine("");
Console.WriteLine($"Сумма чисел на нечётных позициях = {sum}");

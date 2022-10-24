// Задача 41
int sum =0;
Console.WriteLine("Введите количество чисел");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array;
array = new int[kol];
for (int i = 0; i < kol; i++)
{
    Console.WriteLine($"Введите {i+1}-e число");
array[i] = Convert.ToInt32(Console.ReadLine());
if (array[i]>0) sum++;
}
Console.WriteLine($"Количество введенных чисел > 0 = {sum}");
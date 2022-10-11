// Задача 8
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<=a)
{
    double chet = i % 2;
    if (chet == 0)
    {
        Console.WriteLine(i);
    }
i++;
}
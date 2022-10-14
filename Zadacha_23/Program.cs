// Задача 23
Console.Write("Введите число N = ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    Double kub = Math.Pow(i+1, 3);
    Console.WriteLine(kub);
}
// Задача 6
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
double chet = a % 2;
if (chet == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число является нечётным");
}
// Задача 13
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100;
if (b==a)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
string d = Convert.ToString(a);
char The3Symbol = d[2];
Console.WriteLine(The3Symbol);
}

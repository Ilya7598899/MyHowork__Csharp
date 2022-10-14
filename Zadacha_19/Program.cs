// Задача 19 почему-то выделено жёлтым, но всё работает
Console.WriteLine("Введите пятизначное число число");
string a = Console.ReadLine();
if (a[0] == a[4] && a[1] == a[3])
{
    Console.WriteLine("Число - палиндром");
}
else
{
    Console.WriteLine("Число - непалиндром");
}
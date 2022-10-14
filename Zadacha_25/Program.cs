// Задача 25
int[] chisla;
chisla = new int[2];
double stepen = 0;
for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Введите число");
    chisla[i] = Convert.ToInt32(Console.ReadLine());
    if (i==1)
    {
        stepen = Math.Pow(chisla[i - 1], chisla[i]);
    }
    
}
Console.WriteLine("Результат = ");
Console.WriteLine(stepen);
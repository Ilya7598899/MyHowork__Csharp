// Задача 47
Console.Write("Введите ширину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] array;
array = new Double[n+1,m+1];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
    array[i,j] = Convert.ToDouble(rand.Next(-100, 100)/10.0);
    Console.Write($"{array[i,j]} ");
} 
Console.WriteLine(" ");
}

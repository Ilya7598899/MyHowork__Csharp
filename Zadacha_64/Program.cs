// Задача 64
int PrintValue(int n)
{
    if (n==1) return 1;
    else return (n-1);

}

int n=5;
for (int i = n+1; i > 1; i--)
{
    Console.Write($"{PrintValue(i)}, ");
}
Console.WriteLine();
n=8;
for (int i = n+1; i > 1; i--)
{
    Console.Write($"{PrintValue(i)}, ");
}

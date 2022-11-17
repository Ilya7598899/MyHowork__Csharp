// Задача 66
int PrintValue(int N)
{
    if (N == 1) return 1;
    else return N + PrintValue(N-1);
    }
    Console.WriteLine(PrintValue(15));
    Console.Write((PrintValue(8)-6));

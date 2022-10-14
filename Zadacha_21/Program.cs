// Задача 21
int[] A1 = { 3, 6, 8 };
int[] B1 = { 2, 1, -7 };
int[] A2 = { 7, -5, 0 };
int[] B2 = { 1, -1, 9 };

int summ1 = 0;
int summ2 = 0;

int[] temp1XYZA1B1;
temp1XYZA1B1=new int[3];

int[] temp2XYZA2B2;
temp2XYZA2B2=new int[3];

for (int i = 0; i < 3; i++)
{
    temp1XYZA1B1 [i] = (B1[i] - A1[i]) * (B1[i] - A1[i]);
    // temp1XYZA1B1 [i] = Math.Pow((B1[i] - A1[i]), 2);
    summ1 = summ1 + temp1XYZA1B1[i];

    temp2XYZA2B2 [i] = (B2[i] - A2[i]) * (B2[i] - A2[i]);
    //temp2XYZA2B2[i] = Math.Pow((B2[i] - A2[i]), 2);
    summ2 = summ2 + temp2XYZA2B2[i];
}

double lenght1 = Math.Sqrt(summ1);
double lenght2 = Math.Sqrt(summ2);

Console.Write("Длина первого отрезка=");
Console.WriteLine(Math.Round(lenght1,2));

Console.Write("Длина второго отрезка=");
Console.WriteLine(Math.Round(lenght2,2));
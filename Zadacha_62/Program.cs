// Задача 62
int[,] array;
array = new int[4, 4];
int schetchik = 1;
for (int i = 0; i < array.GetLength(0); i++)
{
    array[0, i] = schetchik++;

}

for (int j = 1; j < 4; j++)
    {
        array[j, 3] = schetchik++;
    }

for (int i = 2; i >= 0; i--)
    {
        array[3, i] = schetchik++;
    }

   for (int j = 2; j > 0; j--)
   {
       array[j, 0] = schetchik++;
   }
   for (int i = 1; i < 3; i++)
   {
       array[1, i] = schetchik++;
   }
    for (int j = 2; j < 3; j++)
   {
       array[j, 2] = schetchik++;
   }
    for (int i = 1; i > 0; i--)
   {
       array[2, i] = schetchik++;
   }

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j]<10) Console.Write($"0{array[i, j]} ");

        else Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine($" ");
}
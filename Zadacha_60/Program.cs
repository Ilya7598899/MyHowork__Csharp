// Задача 60
int[,,] array =  {{{ 66, 27}, {25, 90 }}, {{34 , 26}, {41, 55 }}};
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
        }
       Console.WriteLine($" ");
    }
     
}
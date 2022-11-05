// Задача 54
int[,] array = { {1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
for (int i = 0; i < 3; i++)
{
    for (int j = 1; j < 4; j++)
    {
       
        for (int k = 0; k < 4-j; k++)
        {

            if (array[i, k] < array[i, k + 1])

            {
                int temp = 0;
                temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
                
            }


        }
        
    }
  
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
      Console.WriteLine();
}






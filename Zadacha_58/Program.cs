// Задача 58
int[,] MatrixA = { { 1, 4 }, { 3, 5 } };
int[,] MatrixB = { { 3, 5 }, { 1, 2 } };
int[,] MatrixC;
MatrixC = new int[3, 3];
MatrixC[0, 0] = (MatrixA[0, 0] * MatrixB[0, 0] + MatrixA[0, 1] * MatrixB[1, 0]);
MatrixC[0, 1] = (MatrixA[0, 0] * MatrixB[0, 1] + MatrixA[0, 1] * MatrixB[1, 1]);
MatrixC[1, 0] = (MatrixA[1, 0] * MatrixB[0, 0] + MatrixA[1, 1] * MatrixB[1, 0]);
MatrixC[1, 1] = (MatrixA[1, 0] * MatrixB[0, 1] + MatrixA[1, 1] * MatrixB[1, 1]);
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"{MatrixC[i, j]} ");
    }
    Console.WriteLine($" ");
}
// Задача 29
Console.Write("Для геренации случайных чисел введите 1, для ввода чисел с клавиатуры введите 2: ");
int a = Convert.ToInt32(Console.ReadLine());

int length = 0;
int[] array;

if (a == 1)
{
    Random rand = new Random();

    int length2 = rand.Next(0, 10);
    array = new int[length2];

    for (int i = 0; i < length2; i++)
    {
        array[i] = rand.Next(0, 10);
        Console.Write($" {array[i]}");
    }
}

if (a == 2)
{
    Console.Write("Введите длину массива: ");
    length = Convert.ToInt32(Console.ReadLine());
    array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Ваш массив выглядет так: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($" {array[i]}");
    }

}

if (a != 1 && a != 2)
{
    Console.WriteLine("Вы сделали неверный ввод данных, попробуйте еще раз");
}
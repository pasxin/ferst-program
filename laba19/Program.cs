//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Заполняем массив рандомными
void RandomArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next (-100,100) + rnd.NextDouble();
    }
}

// Выводим массив
void WriteArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j].ToString("F" + 2)} ");
        Console.WriteLine("");
    }
}

Console.WriteLine("Введиет колличество строк");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиет колличество столбцов");
int k1 = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[b1, k1];
RandomArray(array);
WriteArray(array);

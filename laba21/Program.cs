//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Заполняем массив рандомными
void RandomArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(-100, 100);
    }
}

// Выводим массив
//void WriteArray(int[,] array)
//{
//   for (int i = 0; i < array.GetLength(0); i++)
//  {
//     for (int j = 0; j < array.GetLength(1); j++)
//        Console.Write($"{array[i, j]} ");
//   Console.WriteLine("");
//}
//}


// Среднее массива
void SrArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = array[i, j] + sum;
        Console.WriteLine(
            $"Средняя среднее арифметическое элементов {j} столбца равна {(sum / array.GetLength(0)).ToString("F" + 2)}"
        );
    }
}

int[,] array = new int[5, 5];
RandomArray(array);
//WriteArray(array);
SrArray(array);

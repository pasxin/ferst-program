//Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

//Выводим массив
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine("");
    }
}

// Сортируем строку
void SortArrayLine(int line, int[,] array)
{
    for (int size = 0; size < array.GetLength(1); size++)
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[line, j] < array[line, j + 1])
            {
                int sort = array[line, j];
                array[line, j] = array[line, j + 1];
                array[line, j + 1] = sort;
            }
        }
}

int[,] array = new int[5, 5];
RandomArray(array);
Console.WriteLine("Заданный массив:");
WriteArray(array);
Console.WriteLine("Сортированный массив:");
for (int i = 0; i < array.GetLength(0); i++)
    SortArrayLine(i, array);
WriteArray(array);

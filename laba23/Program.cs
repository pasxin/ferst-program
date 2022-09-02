//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//с наименьшей суммой элементов.

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

// ищим строчку мин суммы
void FindMinSummLine(int[,] array)
{
    int min = 0;
    int size = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        min = array[0, j] + min;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            summ = summ + array[i, j];
        if (min > summ)
        {
            min = summ;
            size = i;
        }
    }
    Console.WriteLine($"номер строки массива с наименьшей суммой элементов: строка {size}");
}

int[,] array = new int[5, 5];
RandomArray(array);
Console.WriteLine("Заданный массив:");
WriteArray(array); // для проверки (так будем точно уверены что программа работает корректно)
FindMinSummLine(array);

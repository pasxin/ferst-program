//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Заполняем массив рандомными
void RandomArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(-100, 100) + rnd.NextDouble();
    }
}

// Выводим массив
//void WriteArray(double[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
// {
//   for (int j = 0; j < array.GetLength(1); j++)
//      Console.Write($"{array[i, j].ToString("F" + 2)} ");
// Console.WriteLine("");
//}
//}

Console.WriteLine("Введиет значение строки");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиет значение столбеца");
int y = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[5, 5];
RandomArray(array);

//WriteArray(array);
if (x < 0 | array.GetLength(0) - 1 < x | y < 0 | array.GetLength(1) - 1 < y)
    Console.WriteLine("Такого эллемента массива не существует");
else
{
    Console.Write(
        $"Значения элемента с индексами {x} и {y} равен {array[x, y].ToString("F" + 2)} "
    );
}

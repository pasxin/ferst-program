//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//я конечно не знаток математики но разве при умножении матриц 2на2 может получиться матрица 2на2
//(как показано в примере)???Разве не должена получиться матрица содержащий столбец???

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

//Умножаем массив
void MultiplicationArray(int[,] ArrayFerst, int[,] ArraySecond, int[] ArrayResult)
{
    for (int i = 0; i < ArrayFerst.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayFerst.GetLength(0); j++)
            ArrayResult[i] = ArrayFerst[i, j] * ArraySecond[i, j] + ArrayResult[i];
    }
}

int[,] ArrayFerst = new int[2, 2];
int[,] ArraySecond = new int[2, 2];
int[] ArrayResult = new int[2];
RandomArray(ArrayFerst);
RandomArray(ArraySecond);
Console.WriteLine("Заданный массив №1:");
WriteArray(ArrayFerst); // для проверки (так будем точно уверены что программа работает корректно)
Console.WriteLine("Заданный массив №1:");
WriteArray(ArraySecond); // для проверки (так будем точно уверены что программа работает корректно)
Console.WriteLine("Произведение масиивов:");
MultiplicationArray(ArrayFerst, ArraySecond, ArrayResult);
for (int i = 0; i < ArrayFerst.GetLength(0); i++)
    Console.WriteLine(ArrayResult[i]);

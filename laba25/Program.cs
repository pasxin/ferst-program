//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Проверка условия неравинства
int Find(int[,,] array, int ran)
{
    int result = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1); z++)
                if (array[i, j, z] == ran)
                    result = 0;
        }
    }
    return result;
}

// Заполняем массив размером 2*2*2 рандомными
void RandomArray(int[,,] array)
{
    Random rnd = new Random();
    int ran = rnd.Next(10, 100);
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1); z++)
            {
                do
                {
                    ran = rnd.Next(10, 100);
                    result = Find(array, ran);
                } while (result == 0);
                array[i, j, z] = ran;
            }
        }
    }
}

//Выводим массив
void WriteArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1); z++)
                Console.Write($"{array[i, j, z]} ({i}, {j}, {z}) ");
            Console.WriteLine("");
        }
    }
}

int[,,] Array = new int[2, 2, 2];
RandomArray(Array);
WriteArray(Array);

//Напишите программу, которая заполнит спирально массив 4 на 4.

// Заполняем массив рандомными
void RandomArray(int[,] array)
{
    int count = 0;
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i%2==0) 
        {
            for (j = 0; j < array.GetLength(1);j++) 
            {
             array [i,j]=count;
             count = count + 1;
            }
        }
        else
        {
          for (j = array.GetLength(1) - 1; j >= 0; j = j -1) 
            {
             array [i,j]=count;
             count = count + 1;
            }  
        }
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

int[,] Array = new int[4, 4];
RandomArray(Array);
WriteArray(Array);

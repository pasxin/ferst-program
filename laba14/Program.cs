//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int size = 4; //если надо сделать выборку из большего кол-ва чисел
int [] array = new int [size];
//Создание объекта для генерации чисел
Random rnd = new Random();
int result = 0;
for (int count = 0; count<size; count++)
    {
    array[count]= rnd.Next(100, 1000);    
    if (array [count] % 2 == 0) result= result + 1; 
    //Console.WriteLine ($"рандомное значение {count} ячейки массива : {array[count]}"); // делал для проверки
    }
Console.WriteLine ($"количество чётных чисел в массиве : {result}");

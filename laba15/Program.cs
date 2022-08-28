//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int size = 4; //если надо сделать выборку из большего кол-ва чисел
int [] array = new int [size];
Random rnd = new Random();
int result = 0;
for (int count = 0; count<size; count++)
    {
    array[count]= rnd.Next(100, 1000); 
    if (count % 2 != 0) result = result + array[count];
    //Console.WriteLine ($"рандомное значение {count} ячейки массива : {array[count]}"); //делал для проверки
    }
Console.WriteLine ($"Сумма элементов, стоящих на нечётных позициях : {result}");
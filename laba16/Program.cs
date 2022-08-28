//Найдите разницу между максимальным и минимальным элементов массива
// В тексте про вещественные цыфры пишут пример у них целые... что хотят то и пишут... чему научат...
int size = 4; //если надо сделать выборку из большего кол-ва чисел
double [] array = new double [size];
Random rnd = new Random();
array [0]= rnd.NextDouble();
double max = array [0];
double min = array [0];
double result = 0;
//Console.WriteLine ($"рандомное значение {0} ячейки массива : {array[0].ToString("F" + 2)}");
for (int count = 1; count<size; count++)
    {
    array[count]= rnd.NextDouble(); 
    if (array[count]>max) max = array[count];
    if (array[count]<min) min = array[count];
    //Console.WriteLine ($"рандомное значение {count} ячейки массива : {array[count].ToString("F" + 2)}");
    }
result = max-min;
Console.WriteLine ($"Разницу между максимальным и минимальным элементов массива : {result.ToString("F" + 2)}");


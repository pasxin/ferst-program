//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

void NaturSumm (double m, double n)
{
    m = Math.Ceiling (m);
    n = Math.Floor (n);
    double result = 0;
    for (double count = m; count <= n; count ++)
        result = result + count;
    Console.WriteLine ($"Сумму натуральных элементов в промежутке от M до N: {result}");
}

Console.WriteLine ("Введите знаечние M");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите знаечние N");
double n = Convert.ToDouble(Console.ReadLine());
NaturSumm (m, n);
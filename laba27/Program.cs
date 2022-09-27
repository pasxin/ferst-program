//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

void Natur (double m, double n)
{
    m = Math.Ceiling (m);
    n = Math.Floor (n);
    Console.WriteLine ($"Натуральные числа в промежутке от M до N:"); 
    for (double count = m; count <= n; count ++)
        Console.Write ($"{count} "); 
}

Console.WriteLine ("Введите знаечние M");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите знаечние N");
double n = Convert.ToDouble(Console.ReadLine());
Natur (m, n);

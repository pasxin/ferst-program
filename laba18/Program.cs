//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//прям математические задачи пошли уж и забыл как решаются такие)
// Заполняем данные координат в массив
Console.WriteLine ("Введиет коэффициент b уровнения 1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введиет коэффициент k уровнения 1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введиет коэффициент b уровнения 2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введиет коэффициент k уровнения 2");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) Console.WriteLine ("Заданные прямые паралены и не имеют точе пересечения");
    else
    {
    double x = -1*(b1-b2)/(k1-k2);
    double y = k1*x+b1;
    Console.WriteLine ($"Точка пересечения двух прямых ({x.ToString("F" + 2)},{y.ToString("F" + 2)})");
    }

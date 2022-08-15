//  Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// Функция рассчета дельты в квадрате
double delta (double x1, double x2)
{
double result = x2 - x1;
result = result*result;
return result;
}
//-------------Тело программы-------------

// Заполняем данные координат в массив
double [,] array = new double [2,3];
for (int i = 0; i < 2; i++)
   {
    Console.WriteLine ("Введиет координаты "+ (i+1) +" первой точки, последовательно x, y, z: ");
    for (int j = 0; j < 3; j++)
     {
      string String = Console.ReadLine(); 
      double number = Convert.ToInt32(String); 
      array[i, j] = number;
     }
   }
//Производим рассчет
double Summ = 0;
for (int j = 0; j < 3; j++)   
    Summ = delta (array[0, j],array[1, j])+Summ;
double result = Math. Sqrt(Summ);
//Выводим результат
Console.WriteLine ("Расстояние между заданными точками в 3D пространстве: "+ result.ToString("F" + 2));


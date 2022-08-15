//Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Функция рассчета дельты в квадрате
int cub (int x)
{
int result = x*x*x;
return result;
}
//-------------Тело программы-------------
Console.WriteLine ("Введиет значение N");
string String = Console.ReadLine(); 
int N = Convert.ToInt32(String); 
for (int i=1; i <= N;i++)
Console.WriteLine ($"{i} ^ 3 = {cub(i)}");

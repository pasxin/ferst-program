//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// Math.Pow(A, B) - готово)
Console.WriteLine ("Введиет значение A");
string String = Console.ReadLine(); 
int a = Convert.ToInt32(String); 
Console.WriteLine ("Введиет значение B");
String = Console.ReadLine(); 
int b = Convert.ToInt32(String);
int result = 1; 
for (int count = 0; count < b; count ++)
    result = result * a;
Console.WriteLine($"А в степени В равна: {result}");

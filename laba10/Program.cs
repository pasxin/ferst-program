﻿//Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine ("Введиет значение N");
string String = Console.ReadLine(); 
int N = Convert.ToInt32(String); 
for (int i=1; i <= N;i++)
Console.WriteLine ($"{i} ^ 3 = {Math.Pow(i, 3)}");

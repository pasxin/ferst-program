//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
Console.WriteLine ("Введите число");
string text = Console.ReadLine(); 
int size = text.Length;
int number = Convert.ToInt32(text); 
int summ = 0;
for (int count = 1; count <= size; count ++)
    {
    summ = summ + number % 10;
    number = number / 10;
    }
Console.WriteLine($"Сумма цифр в числе равна: {summ}");


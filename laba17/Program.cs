//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Укажите сколько чисел будем передавать в программу");
int size = Convert.ToInt32(Console.ReadLine());
int result = 0;
Console.WriteLine($"Начните последоватеьный ввод чисел");
for (int count=0; count<size;count++)
    {
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) result = result + 1;
    }
Console.WriteLine($"Пользователем введено {result} числа/чисел больше 0");
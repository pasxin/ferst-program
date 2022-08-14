// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine ("Введите 3-х значное число");
string String = Console.ReadLine(); 
int number = Convert.ToInt32(String); 
number=Math.Abs(number);
if (number>999 || number < 100) 
    {Console.Write ("Введено не 3-х значное число");} 
        else
        {
        int result = (number/10) % 10; 
        Console.WriteLine (result);
        }

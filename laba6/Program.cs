//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите число");
string String = Console.ReadLine(); 
int number = Convert.ToInt32(String); 
number=Math.Abs(number);
if (number < 100) 
    {Console.Write ("Третьей цыфры нет");} 
        else
        {
        Console.WriteLine (number.ToString()[2]);
        }
//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine ("Введите день недели");
string String = Console.ReadLine(); 
int number = Convert.ToInt32(String); 
number=Math.Abs(number);
if (number>7 || number < 1) 
    {Console.Write ("Введено не корректное значение дня недели");} 
        else
        {
        if (number>5 || number < 1) 
          {Console.Write ("Выходной");} 
          else {Console.Write ("Рабочий день");}
        }
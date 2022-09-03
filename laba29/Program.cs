//Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29


//              |m + 1                Если n = 0
// ak (n,m) =   |ak (n-1, 1)          Если m = 0
//              |ak (n-1, ak(n,m-1))  Если m и n != 0

int Ak (int n, int m)
{
    int result = 0;
    if (n == 0 & m != 0) result = m +1;
    if (n != 0 & m == 0) result = Ak (n-1,1);
    if (n != 0 & m != 0) result = Ak (n-1,Ak(n,m-1));
    return result;
}

Console.WriteLine ("Введите знаечние n");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите знаечние m");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Ak (n, m));

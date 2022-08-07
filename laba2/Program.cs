// Программа нахождения четных чисел среди чисел указанных с клавиатуры
int count = 0; // Счетчик
Console.WriteLine ("Введите колличество переменных");
//Получение первой строки (он всегда принимает только строкой?)
string String = Console.ReadLine(); 
//Преобразование первой строки в число (хм... а если мы введем текст... как же реализовать засчиту от дурака)
int size = Convert.ToInt32(String); // Переменная колличество чисел
// Создаем массив и заполняем его
int [] array = new int [size];
do
            {
                Console.Write ("Введите значение переменной №",count + 1);
                Console.WriteLine (count + 1);
                array [count] = Convert.ToInt32(Console.ReadLine());
                count = count + 1;
            }
            while (count < size);
// Определяем четные числа
count = 0;
int col = 0;
int [] even = new int [size];
do
            {
                if (array [count] % 2 == 0) {even [col] = array [count];col = col + 1;}
                count = count + 1;
            }
            while (count < size);
// Выводим на все четные знаения 
if (col == 0) {Console.Write ("Среди указанных вами переменных нет четных чисел");} else 
    {
    count = 0;
    Console.Write ("Четные числа среди ваших переменных: ");
    do
                {
                    
                    Console.Write (even [count]);
                    Console.Write (" ");
                    count = count + 1;
                }
                while (count < col);
    }


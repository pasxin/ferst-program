// четные числа в диапазоне до указанного числа
int count = 0; // Счетчик
Console.WriteLine ("Введите колличество переменных");
//Получение первой строки (он всегда принимает только строкой?)
string String = Console.ReadLine(); 
//Преобразование первой строки в число (хм... а если мы введем текст... как же реализовать засчиту от дурака)
int size = Convert.ToInt32(String) + 1; // Переменная колличество чисел
// Определяем четные числа
count = 1;
int col = 0;
int [] even = new int [size];
do
            {
                if (count % 2 == 0) {even [col] = count; col = col + 1;}
                count = count + 1;
            }
            while (count < size);
// Выводим на все четные знаения 

    
    count = 0;
    Console.Write ("Четные числа среди ваших переменных: ");
    do
                {
                    
                    Console.Write (even [count]);
                    Console.Write (" ");
                    count = count + 1;
                }
                while (count < col);

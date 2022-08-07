internal class Program
{
    private static void Main(string[] args)
    {
        //Программа нахождения максимального и минимального числа среди чисел введеных с клавиатуры
        int count = 0; // Счетчик
        int size = 0;
        Console.WriteLine("Введите колличество переменных");
        do 
        {
            //Получение первой строки (он всегда принимает только строкой?)
            string String = Console.ReadLine();
            //Преобразование первой строки в число (хм... а если мы введем текст... как же реализовать засчиту от дурака)
            size = Convert.ToInt32(String); // Переменная колличество чисел
            if (size < 2) {Console.WriteLine("Колличетво переменных должно быть больше 1 шт. Введите колличество переменных повторно");}
        }
        while (size < 2);
        // Создаем массив и заполняем его
        int[] array = new int[size];
       
        do
        {
            Console.Write("Введите значение переменной №");
            Console.WriteLine(count + 1);
            array[count] = Convert.ToInt32(Console.ReadLine());
            count = count + 1;
        }
        while (count < size);
        // Находим максимальное и минимальное  значение
        int max = array [0];
        int min = array [0];
        count = 1;
        do
        {
            if (max < array[count]) { max = array[count]; }
            if (min > array[count]) { min = array[count]; }
            count = count + 1;
        }
        while (count < size);
        // Выводим на экран максимальное значене
        Console.WriteLine("Максимальное число среди введенных вами переменных равно:");
        Console.WriteLine(max);
        Console.WriteLine("Минимальное число среди введенных вами переменных равно:");
        Console.WriteLine(min);
    }
}
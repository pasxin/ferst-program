internal class Program
{
    private static void Main(string[] args)
    {
        //Программа нахождения максимального числа среди чисел введеных с клавиатуры
        int count = 0; // Счетчик
        Console.WriteLine("Введите колличество переменных");
        //Получение первой строки (он всегда принимает только строкой?)
        string String = Console.ReadLine();
        //Преобразование первой строки в число (хм... а если мы введем текст... как же реализовать засчиту от дурака)
        int size = Convert.ToInt32(String); // Переменная колличество чисел
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
        // Находим максимальное значение
        int max = array[0];
        count = 1;
        do
        {
            if (max < array[count]) { max = array[count]; }
            count = count + 1;
        }
        while (count < size);
        // Выводим на экран максимальное значене
        Console.WriteLine("Максимальное число среди введенных вами переменных равно");
        Console.WriteLine(max);
    }
}
namespace Module_4.Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }
            foreach (var color in favcolors)
            {
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color is yellow");
                        break;
                }
            }

            Console.Write("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            foreach (var item in name)
            {
                Console.Write(item + " ");
            }
            Console.Write("Последняя буква Вашего имени: {0}\n", name[name.Length - 1]);

            Console.WriteLine("Имя в обратном порядке");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine();
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nДлина двумерного массива: " + array.Length);
            Console.WriteLine("Количество строк: {0}", array.GetUpperBound(0) + 1);
            Console.WriteLine("Количество столбцов: {0}", array.GetUpperBound(1) + 1);
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Задание 4.3.11
            Console.WriteLine();
            int[,] array_1 = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            for (int i = 0; i < array_1.GetUpperBound(1) + 1; i++)
            {
                for (int j = 0; j < array_1.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(array_1[j, i] + " ");
                }
                Console.WriteLine();
            }

            // Задание 4.3.12 сортировка одномерного массива
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;
            Console.WriteLine("Массив");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
            }
            Console.WriteLine("\nОтсортированный массив");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine("\nСумма всех элементов массива: {0}", sum);

            // Зубчатый массив
            int[][] array_2 = new int[3][];
            array_2[0] = new int[2] { 1, 2 };
            array_2[1] = new int[3] { 1, 2, 3 };
            array_2[2] = new int[5] { 1, 2, 3, 4, 5 };
            //Задание 4.3.14
            Console.WriteLine("Перебор зубчатого массива");
            foreach (var num in array_2)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }
            // Задание 4.3.15 Количество положительный чисел
            int count = 0;
            int[] arr_1 = new int[] { -1, 9, 2, 0, 4, -2, -5 };
            foreach (var item in arr_1)
            {
                if (item >= 0)
                    count++;
            }
            Console.WriteLine("\nКоличество положительный чисел: {0}", count);

            // Задание 4.3.16
            count = 0;
            int[,] arr_2 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            foreach (var num in arr_2)
            {
                if (num > 0)
                    count++;
            }
            Console.WriteLine("\nКоличество положительный чисел: {0}", count);

            // Задание 4.3.17
            for (int i = 0; i < arr_2.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr_2.GetUpperBound(1) + 1; j++)
                {
                    for (int k = j + 1; k < arr_2.GetUpperBound(1) + 1; k++)
                    {
                        if (arr_2[i, j] > arr_2[i, k])
                        {
                            temp = arr_2[i, j];
                            arr_2[i, j] = arr_2[i, k];
                            arr_2[i, k] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Отсортированный двумерный массив");
            for (int i = 0; i < arr_2.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr_2.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(arr_2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace Module_4.Unit_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;

            var result = (myapples != hisapples) & (myapples < hispeares);
            Console.WriteLine(result);

            //Задание 4.1.4
            string A, B;
            A = "Denis";
            B = "Jane";
            bool C = A != B;

            //Задание 4.1.5
            int a = 5;
            int b = 6;
            double x = 7.0;
            double y = 1.0;
            bool c = (a < b) | (x > y);

            Console.WriteLine("Напишите свой любимый цвет на английском языке с маленькой буквы");
            var color = Console.ReadLine();
            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is red");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is green");
            }
            else 
            {
                Console.BackgroundColor= ConsoleColor.Cyan;
                Console.ForegroundColor= ConsoleColor.Black;
                Console.WriteLine("Your color is cyan");
            }
        }
    }
}

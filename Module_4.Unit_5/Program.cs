namespace Module_4.Unit_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(string name, int age) anketa;
            //Console.WriteLine("Введите Ваше имя:");
            //anketa.name = Console.ReadLine();
            //Console.WriteLine("Введите Ваш возраст цифрами:");
            //anketa.age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //Задание 4.4.3
            var (name, age) = ("Denis", 32);
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            
            Console.WriteLine("Введите Ваше имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст цифрами:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            //Задание 4.4.5
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Введите имя питомца:");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("Введите тиа питомца:");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Введите возраст питомца цифрами:");
            Pet.Age = int.Parse(Console.ReadLine());
        }
    }
}

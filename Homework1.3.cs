using System;

namespace ConsoleApp2
{
    internal class Homework1
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSign;
            string job;

            Console.WriteLine("Приветствую! Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кто вы по гороскопу?");
            zodiacSign = Console.ReadLine();
            Console.WriteLine("Кем мы работаете?");
            job = Console.ReadLine();

            Console.WriteLine($"\nВас зовут {name}, вам {age}, ваш знак зодиака {zodiacSign}. Вы работаете {job}.");
        }
    }
}

﻿using System;

namespace ConsoleApp2
{
    internal class Homework1
    {
        static void Main(string[] args)
        {
            string correctName;
            string newCupOfTea;

            string name = "Колоколова";
            string surname = "Вика";
            string cupOfTea = "Кофе";
            string cupOfCoffee = "Чай";

            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {surname}");
            Console.WriteLine($"В чашке чая находится: {cupOfTea}, а в чашку кофе налили: {cupOfCoffee}");

            Console.WriteLine($"\nИсправим ошибку с именем и фамилией!");
            correctName = surname;
            surname = name;
            name = correctName;
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия {surname}");

            Console.WriteLine($"\nИсправим ошибку с напитками!");
            newCupOfTea = cupOfCoffee;
            cupOfCoffee = cupOfTea;
            cupOfTea = newCupOfTea;
            Console.WriteLine($"В чашке для чая налит: {cupOfTea}, а в чашке для кофе: {cupOfCoffee}");
        }
    }
}

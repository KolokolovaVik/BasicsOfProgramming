//using System;
//using System.Collections.Generic;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int food;
//            int money;
//            int foodUnitMoney = 10;
//            bool isAbleToPay;

//            Console.WriteLine($"Добро пожаловать! Еда по {foodUnitMoney} монет");
//            Console.WriteLine("Сколько у вас золота?");
//            money = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Сколько еды вы хотите?");
//            food = Convert.ToInt32(Console.ReadLine());

//            isAbleToPay = money >= food * foodUnitMoney;
//            food *= Convert.ToInt32(isAbleToPay);
//            money -= food * foodUnitMoney;
//            Console.WriteLine($"У вас {food} еды и {money} монет золота");
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Homework17
    {
        static void Main(string[] args)
        {
            int patients;
            int waitTime;
            int hours;
            int minutes;

            int timeSpentOnePatient = 10;
            int oneHourMinutes = 60;

            Console.WriteLine("Введите кол-во людей в очереди:");
            patients = Convert.ToInt32(Console.ReadLine());

            waitTime = patients * timeSpentOnePatient;
            hours = waitTime / oneHourMinutes;
            minutes = waitTime % oneHourMinutes;

            Console.WriteLine($"Вы должны отстоять в очереди {hours} часа и {minutes} минут.");
        }
    }
}

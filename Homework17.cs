using System;

namespace ConsoleApp2
{
    internal class Homework17
    {
        static void Main(string[] args)
        {
            int patients;
            int totalWaitingTimeMinutes;
            int waitingHoursQueue;
            int waitingMinutesQueue;

            int timeSpentOnePatient = 10;
            int oneHourMinutes = 60;

            Console.WriteLine("Введите кол-во людей в очереди:");
            patients = Convert.ToInt32(Console.ReadLine());

            totalWaitingTimeMinutes = patients * timeSpentOnePatient;
            waitingHoursQueue = totalWaitingTimeMinutes / oneHourMinutes;
            waitingMinutesQueue = totalWaitingTimeMinutes % oneHourMinutes;

            Console.WriteLine($"Вы должны отстоять в очереди {waitingHoursQueue} часа и {waitingMinutesQueue} минут.");
        }
    }
}

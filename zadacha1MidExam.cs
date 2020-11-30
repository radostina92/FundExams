using System;

namespace _01.Zadacha
{
    class zadacha1MidExam
    {
        static void Main(string[] args)
        {
            int biscuitPerDayPerWorker = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int biscuitsFor30Days = int.Parse(Console.ReadLine());

            int bisciutPerWorker = biscuitPerDayPerWorker * workersCount;
            double factoryProduce = 0;

            for (int i = 1; i <= 30; i++)
            {

                if (i % 3 == 0)
                {
                    factoryProduce += Math.Floor(bisciutPerWorker * 0.75);
                }
                else
                {
                    factoryProduce += bisciutPerWorker;
                }
            }

            Console.WriteLine($"You have produced {factoryProduce} biscuits for the past month.");
            if (factoryProduce > biscuitsFor30Days)
            {
                double percentage = factoryProduce - biscuitsFor30Days;
                percentage = percentage / biscuitsFor30Days * 100;
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                double percentage = biscuitsFor30Days - factoryProduce;
                percentage = percentage / biscuitsFor30Days * 100;

                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}

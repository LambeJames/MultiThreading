using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        public static void MakeACupOfTea()
        {
            Thread.Sleep(2000);
        }

        public static void MakeABaconButty()
        {
            Thread.Sleep(3000);
        }

        static void Main(string[] args)
        {
            var makeACupOfTea = new Thread(MakeACupOfTea);
            makeACupOfTea.Start();

            var makeABaconButty = new Thread(MakeABaconButty);
            makeABaconButty.Start();

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Checking on Breakfast");
                Console.WriteLine(makeACupOfTea.IsAlive ? "Cuppa still brewing" : "Cuppa ready");
                Console.WriteLine(makeABaconButty.IsAlive ? "Bacon smells great but still not ready" : "Butty good to eat!");

                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}

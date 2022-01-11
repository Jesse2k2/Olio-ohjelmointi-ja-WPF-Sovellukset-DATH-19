using System;

namespace harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            ajoneuvo auto = new ajoneuvo();

            auto.Nimi = "Toyota";
            auto.Nopeus = 160;
            auto.Renkaat = 4;

            auto.TulostaData();

            string autonTiedot = auto.ToString();
            Console.WriteLine(autonTiedot);

            Console.WriteLine();

            ajoneuvo mopo = new ajoneuvo();
            mopo.Nimi = "Skootteri";
            mopo.Nopeus = 55;
            mopo.Renkaat = 2;

            mopo.TulostaData();
            Console.Write(mopo.ToString());
        }
    }
}

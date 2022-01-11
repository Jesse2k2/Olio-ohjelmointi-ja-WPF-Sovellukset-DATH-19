using System;

namespace HArjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira mopsi1 = new Koira();
            Koira koira2 = new Koira();

            mopsi1.Nimi = "rekku";
            mopsi1.ikä = 2;
            mopsi1.Rotu = "Mopsi";

            koira2.Nimi = "asd";
            koira2.ikä = 3;
            koira2.Rotu = "Saksanpaimenkoira";

            koira2.Hauku();
            Console.WriteLine(koira2.Haetiedot());

            Console.WriteLine(mopsi1.Haetiedot());
            mopsi1.Hauku();
            mopsi1.Hauku();

        }
        

    }
}

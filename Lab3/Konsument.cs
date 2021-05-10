using System;
namespace Lab3
{
    class Konsument : Watek
    {
        public Konsument(Dane pudelko) : base(pudelko)
        {

        }

        protected override void DzialanieWatku()
        {
            while (true)
            {
                Console.WriteLine($"Konsument: {pudelko.zajetosc}");
            }
        }
    }
}


using System;
namespace Lab3
{
    class Producent : Watek
    {
        public Producent(Dane pudelko) : base(pudelko)
        {

        }

        protected override void DzialanieWatku()
        {
            while (true)
            {
                Console.WriteLine($"Producent: {pudelko.zajetosc}");
                pudelko.zajetosc++;
            }
        }
    }
}


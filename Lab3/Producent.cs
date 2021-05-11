using System;
using System.Threading;

namespace Lab3
{
    class Producent : Watek
    {
        public Producent(Dane daneBuforu,int id) : base(daneBuforu,id)
        {

        }
        protected override void DzialanieWatku()
        {
            Random rng = new Random();
            while (true)
            {
                daneBuforu.sem.WaitOne();
                if (daneBuforu.ilosc!=daneBuforu.rozmiar)
                {
                    daneBuforu.bufor[(daneBuforu.pierwszy + daneBuforu.ilosc) % daneBuforu.rozmiar] = rng.Next(1,101);
                    Console.WriteLine($"[{id}]Wyprodukowano: {daneBuforu.bufor[(daneBuforu.pierwszy + daneBuforu.ilosc) % daneBuforu.rozmiar]}");
                    daneBuforu.ilosc++;
                }
                else
                {
                }
                daneBuforu.sem.Release();
            }
        }
    }
}


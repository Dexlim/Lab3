﻿using System;
using System.Threading;
namespace Lab3
{
    class Konsument : Watek
    {
        public Konsument(Dane daneBuforu,int id) : base(daneBuforu,id)
        {
            this.opoznienie = 0;
        }

        protected override void DzialanieWatku()
        {
            while (true)
            {
                daneBuforu.sem.WaitOne();
                if (daneBuforu.ilosc>0)
                {

                    Console.WriteLine($"\t\t\t\t[{id}]Skonsumowano: {daneBuforu.bufor[daneBuforu.pierwszy]}");
                    daneBuforu.pierwszy = (daneBuforu.pierwszy + 1) % daneBuforu.rozmiar;
                    daneBuforu.ilosc--;
                }
                else
                {
                }
                daneBuforu.sem.Release();
                Thread.Sleep(opoznienie);
            }
            
        }
    }
}


using System;
using System.Threading;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProdKons = new Laboratorium3(10);
            ProdKons.Run();
        }
    }

    class Laboratorium3
    {
        private int zajetosc = 0;
        private int rozmiar;
        private int[] bufor;

        public Laboratorium3(int rozmiar)
        {
            this.zajetosc = 0;
            this.rozmiar = rozmiar;
            this.bufor = new int[rozmiar];
        }

        public void Run()
        {
            Thread producent = new Thread(FunkcjaProducenta);
            Thread konsument = new Thread(FunkcjaKonsumenta);

            producent.Start();
            konsument.Start();

            producent.Join();
            konsument.Join();

        }

        public void FunkcjaProducenta()
        {
            while (true)
            {
                if (zajetosc < 10)
                {

                }
                else
                {

                }
            }
        }

        public void FunkcjaKonsumenta()
        {

        }
    }
}


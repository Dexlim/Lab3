using System;
using System.Threading;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProdKons = new Laboratorium3();
            ProdKons.Run();
        }
    }

    class Laboratorium3
    {
        private static int rozmiarBufora = 10;
        private static int zajetosc = 0;
        private int[] bufor = new int[rozmiarBufora];
        public void Run()
        {


            Thread producent = new Thread(FunkcjaProducenta);
            Thread konsument = new Thread(FunkcjaKonsumenta);

            producent.Start();
           // konsument.Start();

            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine("Main: "+zajetosc); // Debug
                zajetosc++;
                Thread.Sleep(100);
            }

            producent.Join();

        }

        public static void FunkcjaProducenta()
        {
            while (true)
            {
                if (zajetosc < 10)
                {
                    Console.WriteLine(zajetosc);
                   // zajetosc++;
                }
                else
                {
                    return;
                }
            }
        }

        public static void FunkcjaKonsumenta()
        {
            
        }
    }
 }


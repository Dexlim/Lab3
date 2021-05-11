using System.Threading;

namespace Lab3
{
    public class Dane
    {
        public int ilosc = 0;
        public int pierwszy = 0;
        public int rozmiar;
        public int[] bufor;
        public Semaphore sem = new Semaphore(1,1);
        public Dane(int rozmiar)
        {
            this.rozmiar = rozmiar;
            this.bufor = new int[rozmiar];
        }
    }
}


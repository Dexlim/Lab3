namespace Lab3
{
    public class Dane
    {
        public int zajetosc = 0;
        public int rozmiar;
        public int[] bufor;
        public Dane(int rozmiar)
        {
            this.rozmiar = rozmiar;
            this.bufor = new int[rozmiar];
        }
    }
}


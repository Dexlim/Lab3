namespace Lab3
{
    class Laboratorium3
    {
        Dane daneBuforu;

        public Laboratorium3(int rozmiar)
        {
            daneBuforu = new Dane(rozmiar);
        }
        public void Run()
        {
            var prod1 = new Producent(daneBuforu);
            prod1.Start();
            var kons1 = new Konsument(daneBuforu);
            kons1.Start();

        }
    }
}


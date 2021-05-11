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
            var prod1 = new Producent(daneBuforu,1);
            prod1.Start();
            var kons1 = new Konsument(daneBuforu,2);
            kons1.Start();
            var prod2 = new Producent(daneBuforu, 3);
            prod2.Start();
            var kons2 = new Konsument(daneBuforu, 4);
            kons2.Start();

        }
    }
}


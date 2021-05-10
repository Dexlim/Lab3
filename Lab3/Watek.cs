using System.Threading;
namespace Lab3
{
    abstract class Watek
    {
        private Thread watek;
        protected Dane pudelko;
        public Watek(Dane pudelko)
        {
            watek = new Thread(DzialanieWatku);
            this.pudelko = pudelko;
        }
        public void Start()
        {
            watek.Start();
        }

        public void Join()
        {
            watek.Join();
        }

        protected abstract void DzialanieWatku();
    }
}


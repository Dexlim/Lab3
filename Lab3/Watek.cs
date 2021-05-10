using System.Threading;
namespace Lab3
{
    abstract class Watek
    {
        private Thread watek;
        protected Dane daneBuforu;
        public Watek(Dane daneBuforu)
        {
            watek = new Thread(DzialanieWatku);
            this.daneBuforu = daneBuforu;
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


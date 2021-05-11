using System.Diagnostics;
using System.Threading;
namespace Lab3
{
    abstract class Watek
    {
        private Thread watek;
        protected Dane daneBuforu;
        protected int id;
        protected int opoznienie;
        public Watek(Dane daneBuforu,int id)
        {
            watek = new Thread(DzialanieWatku);
            this.daneBuforu = daneBuforu;
            this.id = id;
            this.opoznienie = 0;
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


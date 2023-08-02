using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Jablko
    {
        protected Random rand = new Random(DateTime.Now.Ticks.GetHashCode());
        public int x;
        public int y;
        protected Had had;
        protected DateTime vznik;

        public DateTime Vznik
        {
            get => vznik;

            set => vznik = value;
        }

        public Jablko(Had had)
        {
            this.x = rand.Next(1, 44);
            this.y = rand.Next(1, 25);
            this.had = had;
            this.vznik = DateTime.Now;

            this.KontrolaNeniHad();
        }

        public void KontrolaNeniHad()
        {
            foreach (Tuple<int, int> tuple in this.had.telo)
            {
                if (this.x == tuple.Item1 && this.y == tuple.Item2 && tuple != had.telo.Last())
                {
                    this.Vygenerovat();
                    this.KontrolaNeniHad();
                }
            }
        }

        public void Vygenerovat()
        {
            this.x = rand.Next(1, 44);
            this.y = rand.Next(1, 25);
            this.vznik = DateTime.Now;

            this.KontrolaNeniHad();
        }

        public void Vykresli(System.ConsoleColor barva)
        {
            Console.CursorLeft = this.x * 2;
            Console.CursorTop = this.y;
            Console.ForegroundColor = barva;
            Console.Write("██");
        }

        public void KontrolaKonceZivotnosti()
        {
            if (DateTime.Now > Vznik.AddSeconds(20))
            {
                Console.CursorLeft = this.x * 2;
                Console.CursorTop = this.y;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("██");
                this.Vygenerovat();
                Vznik = Vznik.AddSeconds(30);
            }
        }
    }
}

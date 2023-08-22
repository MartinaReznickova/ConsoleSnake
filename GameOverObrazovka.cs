using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class GameOverObrazovka : Obrazovka
    {
        private Hra hra;

        public GameOverObrazovka(Hra hra)
        {
            this.hra = hra;

        }

        public void Spustit()
        {
            Console.Clear();
            Console.CursorVisible = false;

            this.GameOverNapisVykreslit();
            this.ScoreVypsat(hra);
            this.BestScoreVypsat();

            MenuNaKonci menuNaKonci = new MenuNaKonci(hra);
            menuNaKonci.VypsatMoznosti();
        }
    }
}

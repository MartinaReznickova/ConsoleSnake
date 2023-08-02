using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class MenuNaKonci : MenuUvodni
    {
        private Hra hra;

        public MenuNaKonci(Hra hra)
        {
            this.moznosti = new string[] { "Play Again", "Speed setting", "About", "Exit" };
            this.SetCursorPositionTop = 25;
            this.hra = hra;
        }

        public override void Spustit()
        {
            Console.Clear();
            Console.CursorVisible = false;

            this.GameOverNapisVykreslit();
            this.ScoreVypsat(hra);
            this.BestScoreVypsat();
            this.VypsatMoznosti();

        }
    }
}

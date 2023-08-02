using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Hra : AbstractObrazovka
    {
        public int Score { get; set; }

        public Hra()
        {
            Score = 0;
        }

        public void Spustit()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Had had = new Had();
            Jablko jablko = new Jablko(had);
            OtraveneJablko otravene = new OtraveneJablko(jablko, had);

            while (had.Zivy)
            {
                jablko.KontrolaKonceZivotnosti();
                otravene.KontrolaKonceZivotnosti();

                this.OkrajeVykreslit();
                Console.WriteLine();
                this.ScoreVypsat(this);
                had.Vykresli();
                jablko.Vykresli(ConsoleColor.Red);
                had.Lez(this, jablko, otravene);

                while (Score % 5 == 0 && Score != 0)
                {
                    otravene.Vykresli(ConsoleColor.Green);
                    break;

                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo klavesa = Console.ReadKey();

                    if (klavesa.Key == ConsoleKey.RightArrow)
                        if (had.Smer == 180)
                            continue;
                        else { had.Smer = 0; }
                    if (klavesa.Key == ConsoleKey.LeftArrow)
                        if (had.Smer == 0)
                            continue;
                        else { had.Smer = 180; }
                    if (klavesa.Key == ConsoleKey.DownArrow)
                        if (had.Smer == 90)
                            continue;
                        else { had.Smer = 270; }
                    if (klavesa.Key == ConsoleKey.UpArrow)
                        if (had.Smer == 270)
                            continue;
                        else { had.Smer = 90; }
                    if (klavesa.Key == ConsoleKey.Spacebar)
                        had.VyplazniJazyk(had.telo.Last());

                    else
                    {
                        continue;
                    }
                }

            }
            Thread.Sleep(1000);
            Hudba.SpustitHudbu("GAME_OVER.wav");
            BestScore.AktualizovatBestScore(Score);
            GameOverObrazovka gameOverObrazovka = new GameOverObrazovka(this);
            gameOverObrazovka.Spustit();
        }
    }
}

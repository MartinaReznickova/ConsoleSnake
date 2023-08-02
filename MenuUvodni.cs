using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class MenuUvodni : AbstractObrazovka
    {
        protected string[] moznosti;
        protected int indexMoznosti = 0;
        protected bool menuJeSpustene = true;
        protected int SetCursorPositionTop;
        private const System.ConsoleColor barvaVyberu = ConsoleColor.Red;
        private const int beepFrequency = 600;

        public MenuUvodni()
        {
            this.moznosti = new string[] { "Play", "Speed setting", "About", "Exit" };
            this.SetCursorPositionTop = 17;
        }

        public void VypsatMoznosti()
        {
            Console.SetCursorPosition(0, this.SetCursorPositionTop);
            Console.ForegroundColor = ConsoleColor.White;

            foreach (string s in moznosti)
            {
                if (Array.IndexOf(moznosti, s) == indexMoznosti)
                {
                    Console.WriteLine("     <<{0}>>     ", s, Console.BackgroundColor = barvaVyberu);
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                else { Console.WriteLine("     << {0} >>     ", s, Console.BackgroundColor = ConsoleColor.Black); }

            }
            this.Volba();
        }

        public void Volba()
        {
            Console.SetCursorPosition(0, this.SetCursorPositionTop);
            Console.CursorVisible = false;

            while (this.menuJeSpustene == true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo klavesa = Console.ReadKey();

                    if (klavesa.Key == ConsoleKey.DownArrow)
                    {
                        Console.Beep(beepFrequency, 80);
                        this.indexMoznosti++;

                        if (this.indexMoznosti > moznosti.Length - 1)
                        {
                            this.indexMoznosti = 0;
                        }

                        this.VypsatMoznosti();
                    }

                    if (klavesa.Key == ConsoleKey.UpArrow)
                    {
                        Console.Beep(beepFrequency, 80);
                        this.indexMoznosti--;

                        if (this.indexMoznosti < 0)
                        {
                            this.indexMoznosti = 3;
                        }

                        this.VypsatMoznosti();
                    }

                    if (klavesa.Key == ConsoleKey.Enter)
                    {
                        Console.Beep(beepFrequency, 80);

                        if (this.indexMoznosti == 0)
                        {
                            if (this is MenuNaKonci)
                            {
                                Hudba.SpustitHudbu("SNAKE.wav");
                            }
                            Hra hra = new Hra();
                            hra.Spustit();
                            menuJeSpustene = false;
                        }

                        else if (this.indexMoznosti == 1)
                        {
                            NastaveniRychlostiObrazovka nastaveni = new NastaveniRychlostiObrazovka(this);
                            nastaveni.Spustit();
                        }

                        else if (this.indexMoznosti == 2)
                        {
                            AboutObrazovka popis = new AboutObrazovka(this);
                            popis.Spustit();
                        }

                        else if (this.indexMoznosti == 3)
                        {
                            Environment.Exit(0);

                        }
                    }
                }
            }
        }

        public virtual void Spustit()
        {
            Console.Clear();
            Console.CursorVisible = false;

            this.SnakeNapisVykreslit();
            this.VypsatMoznosti();
        }
    }
}

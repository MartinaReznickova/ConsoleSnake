using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    internal class NastaveniRychlostiObrazovka : AbstractObrazovka
    {
        private int indexMoznosti = 0;
        public int indexVybraneRychlosti = GlobalRychlostHada.IndexRychlosti();
        private string[] moznosti = new string[] { "Fast", "Medium", "Slow", "Back To Menu" };
        private MenuUvodni menu;
        private bool spusteneNastaveni = true;


        public NastaveniRychlostiObrazovka(MenuUvodni menu)
        {
            this.menu = menu;

        }

        public void Spustit()
        {
            Console.Clear();
            Console.CursorVisible = false;

            this.SnakeNapisVykreslit();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    SPEED SETTING:     \n");
            this.VypsatRychlosti();

        }

        public void VypsatRychlosti()
        {
            foreach (string s in moznosti)
            {
                if (s == "Back To Menu")
                {
                    if (Array.IndexOf(moznosti, s) == indexMoznosti)
                    {
                        Console.WriteLine("\n\n\n     <<{0}>>     ", s, Console.BackgroundColor = ConsoleColor.Red);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    else
                    {
                        Console.WriteLine("\n\n\n     <<{0}>>     ", s, Console.BackgroundColor = ConsoleColor.Black);

                    }
                }
                else if (Array.IndexOf(moznosti, s) == indexVybraneRychlosti)
                {
                    Console.WriteLine("     <<{0}>>     ", s, Console.BackgroundColor = ConsoleColor.Green);
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                else if (Array.IndexOf(moznosti, s) == indexMoznosti)
                {

                    Console.WriteLine("     <<{0}>>     ", s, Console.BackgroundColor = ConsoleColor.Red);
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                else
                {
                    Console.WriteLine("     << {0} >>     ", s, Console.BackgroundColor = ConsoleColor.Black);
                }

            }

            this.VolbaRychlosti();

        }

        public void VolbaRychlosti()
        {
            Console.SetCursorPosition(0, 19);
            Console.CursorVisible = false;

            while (this.spusteneNastaveni == true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo klavesa = Console.ReadKey();

                    if (klavesa.Key == ConsoleKey.DownArrow)
                    {
                        Console.Beep(600, 80);
                        this.indexMoznosti++;


                        if (this.indexMoznosti > 3)
                        {
                            this.indexMoznosti = 0;
                        }

                        this.VypsatRychlosti();
                    }

                    if (klavesa.Key == ConsoleKey.UpArrow)
                    {
                        Console.Beep(600, 80);
                        this.indexMoznosti--;

                        if (this.indexMoznosti < 0)
                        {
                            this.indexMoznosti = 3;
                        }

                        this.VypsatRychlosti();
                    }

                    if (klavesa.Key == ConsoleKey.Enter)
                    {
                        Console.Beep(700, 80);

                        if (this.indexMoznosti == 0)
                        {
                            this.indexVybraneRychlosti = 0;

                        }

                        else if (this.indexMoznosti == 1)
                        {
                            this.indexVybraneRychlosti = 1;
                        }

                        else if (this.indexMoznosti == 2)
                        {
                            this.indexVybraneRychlosti = 2;
                        }

                        else if (this.indexMoznosti == 3)
                        {
                            this.VratitSeDoMenu();
                        }
                        GlobalRychlostHada.PrenastavitIndexRychlosti(indexVybraneRychlosti);
                        this.VypsatRychlosti();


                    }
                }
            }
        }

        public void VratitSeDoMenu()
        {
            menu.Spustit();

        }
    }
}

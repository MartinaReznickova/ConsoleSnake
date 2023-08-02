using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class AboutObrazovka : AbstractObrazovka
    {
        private string popis;
        private MenuUvodni menu;

        public AboutObrazovka(MenuUvodni menu)
        {
            this.popis = "    Navigate the slithering serpent through a maze of challenges!\n    Control the snake's movement using arrow keys and indulge in a quest\n    for delicious red apples, while avoiding the poisonous green ones.\n    Eating the red apples boosts your score,\n    but beware the green ones, for they spell doom.\n    Accidentally feast on a green apple, and the snake meets its untimely end.\n    Furthermore, don't let the snake collide with the surrounding walls,\n    as that leads to a fatal outcome too.\n    Press the spacebar to watch the snake extend its tongue.\n\n    Can you master this classic arcade game?\n";
            this.menu = menu;

        }

        public void Spustit()
        {
            Console.Clear();
            Console.CursorVisible = false;
            this.SnakeNapisVykreslit();
            Console.ForegroundColor = ConsoleColor.White;
            this.VypsatPopis();
            this.BackToMenuVykreslit();

            ConsoleKeyInfo klavesa = Console.ReadKey();

            if (klavesa.Key == ConsoleKey.Enter)
            {
                this.VratitSeDoMenu();
            }
            else
            {

                while (klavesa.Key != ConsoleKey.Enter)
                {
                    klavesa = Console.ReadKey();

                    if (klavesa.Key == ConsoleKey.Enter)
                    {
                        this.VratitSeDoMenu();
                    }

                }
            }
        }

        public void VratitSeDoMenu()
        {
            this.menu.Spustit();
        }

        public void VypsatPopis()
        {
            foreach (var pismeno in this.popis)
            {
                Console.Write(pismeno);
                Thread.Sleep(25);
            }
        }
    }
}

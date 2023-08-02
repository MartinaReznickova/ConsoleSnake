using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Martina's Snake Game";
            Console.SetWindowSize(90, 33);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;

            Hudba.SpustitHudbu("SNAKE.wav");
            MenuUvodni menuUvodni = new MenuUvodni();
            menuUvodni.Spustit();

        }
    }
}

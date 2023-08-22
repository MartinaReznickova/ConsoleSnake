using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ConsoleSnake
{
    class Obrazovka
    {
        public void SnakeNapisVykreslit()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\r\n   █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █\r\n                                                                                        \r\n      ███████████████████████████████████████████████████████████████                 \r\n      ██                                                           ██   ██████         \r\n      ██            ████     ██  ████████  ██  ███   ████████      ██   ██  ██        \r\n      ███████████   ██ ██    ██  ███   ██  ██ ██     ██            ██   ██  ██         \r\n               ██   ██  ██   ██        ██  ████      ████████      ██   ██  ██████-<\r\n               ██   ██   ██  ██  ████████  ██ ██     ██            ███████    \r\n      ██       ██   ██    ██ ██  ██    ██  ██  ██    ██                       \r\n      ███████████   ██     ████  ████████  ██   ███  ████████      \r\n    \r\n   █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }
        }

        public void GameOverNapisVykreslit()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █\r\n                                                                                       \r\n   █  ██████████                            ██████████                                 █\r\n      ██      ██                            ██      ██                                  \r\n   █  ██         ██████ ██         ███████  ██      ██ ███      ███ ███████ ██         █\r\n      ██             ██ ██████████ ██       ██      ██  ███    ███  ██      ████████    \r\n   █  ██    ████ ██████ ██  ██  ██ ███████  ██      ██   ██    ██   ███████ ██    ██   █\r\n      ██      ██ ██  ██ ██  ██  ██ ██       ██      ██    ██  ██    ██      ██          \r\n   █  ██████████ ██████ ██  ██  ██ ███████  ██████████     ████     ███████ ██         █\r\n   \r\n   █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █");
            Console.WriteLine("\n");
        }

        public void OkrajeVykreslit()
        {
            //levy okraj
            for (int j = 1; j < 26; j++)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.CursorLeft = i * 2;
                    Console.CursorTop = j;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("██");
                }

            }
            //horni okraj
            for (int j = 0; j < 1; j++)
            {
                for (int i = 0; i < 45; i++)
                {
                    Console.CursorLeft = i * 2;
                    Console.CursorTop = j;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("█ ");
                }
            }

            //dolni okraj
            for (int j = 26; j < 27; j++)
            {
                for (int i = 0; i < 45; i++)
                {
                    Console.CursorLeft = i * 2;
                    Console.CursorTop = j;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" █");
                }
            }

            //pravy okraj
            for (int j = 1; j < 26; j++)
            {
                for (int i = 44; i < 45; i++)
                {
                    Console.CursorLeft = i * 2;
                    Console.CursorTop = j;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("██");
                }
            }
        }

        public void ScoreVypsat(Hra hra)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string textScore = " \r\n __   __  __   __   __   \r\n|__  |   |  | |__| |__ *\r\n __| |__ |__| | |  |__ *";
            Console.WriteLine("{0}     {1}", textScore, hra.Score);
        }

        public void BackToMenuVykreslit()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n    <<Back to menu>>     ", Console.BackgroundColor = ConsoleColor.Red);
            Console.BackgroundColor = ConsoleColor.Black;


        }

        public void BestScoreVypsat()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string textBestScore = "\r\n _    __   __  ___   __   __  __   __   __  \r\n|__  |__  |__   |   |__  |   |  | |__| |__ *\r\n|__| |__   __|  |    __| |__ |__| | |  |__ *";
            Console.WriteLine("{0}     {1}", textBestScore, BestScore.BestScoreUlozene());
        }
    }
}


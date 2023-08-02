using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Had
    {
        public bool Zivy { get; set; }
        public List<Tuple<int, int>> telo = new List<Tuple<int, int>>();
        public int Rychlost { get; set; }

        public int Smer { get; set; }

        public Had()
        {
            Zivy = true;
            Smer = 0;

            for (int i = 2; i < 12; i++)
            {
                telo.Add(new Tuple<int, int>(i, 10));
            }

            Rychlost = GlobalRychlostHada.IndexRychlosti();
        }


        public void Lez(Hra hra, Jablko jablko, OtraveneJablko otravene)
        {
            Console.CursorLeft = telo.First().Item1 * 2;
            Console.CursorTop = telo.First().Item2;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  ");

            telo.Remove(telo.First());
            Thread.Sleep(Rychlost * 25);

            if (Smer == 0)//leze doprava
            {
                if (telo.Last().Item1 + 1 == 44 || telo.Last().Item2 == 26 || this.KontrolaJestliNeniHad(new Tuple<int, int>(telo.Last().Item1 + 1, telo.Last().Item2)) == true)
                {

                    Zivy = false;
                }

                else
                {
                    this.SnistJablko(telo.Last().Item1, telo.Last().Item2, jablko, otravene, hra);
                    telo.Add(new Tuple<int, int>(telo.Last().Item1 + 1, telo.Last().Item2));
                }

            }

            else if (Smer == 180)//leze doleva
            {
                if (telo.Last().Item1 - 1 == 0 || telo.Last().Item2 == 0 || this.KontrolaJestliNeniHad(new Tuple<int, int>(telo.Last().Item1 - 1, telo.Last().Item2)) == true)
                {
                    Zivy = false;
                }

                else
                {
                    this.SnistJablko(telo.Last().Item1, telo.Last().Item2, jablko, otravene, hra);
                    telo.Add(new Tuple<int, int>(telo.Last().Item1 - 1, telo.Last().Item2));
                }

            }

            else if (Smer == 90)//leze nahoru
            {
                if (telo.Last().Item1 == 0 || telo.Last().Item2 - 1 == 0 || this.KontrolaJestliNeniHad(new Tuple<int, int>(telo.Last().Item1, telo.Last().Item2 - 1)) == true)
                {
                    Zivy = false;
                }

                else
                {
                    this.SnistJablko(telo.Last().Item1, telo.Last().Item2, jablko, otravene, hra);
                    telo.Add(new Tuple<int, int>(telo.Last().Item1, telo.Last().Item2 - 1));
                }
            }

            else if (Smer == 270)//leze dolu
            {
                if (telo.Last().Item1 == 44 || telo.Last().Item2 + 1 == 26 || this.KontrolaJestliNeniHad(new Tuple<int, int>(telo.Last().Item1, telo.Last().Item2 + 1)) == true)
                {
                    Zivy = false;
                }

                else
                {
                    this.SnistJablko(telo.Last().Item1, telo.Last().Item2, jablko, otravene, hra);
                    telo.Add(new Tuple<int, int>(telo.Last().Item1, telo.Last().Item2 + 1));
                }
            }
        }

        public void Vykresli()
        {
            foreach (Tuple<int, int> tuple in telo)
            {
                Console.CursorLeft = tuple.Item1 * 2;
                Console.CursorTop = tuple.Item2;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("█");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("█");

            }
        }

        public void VyplazniJazyk(Tuple<int, int> tuple)
        {
            if (tuple == telo.Last() && Smer == 0)
            {
                Console.CursorLeft = tuple.Item1 * 2;
                Console.CursorTop = tuple.Item2;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("-<");
            }

            else if (tuple == telo.Last() && Smer == 180)
            {
                Console.CursorLeft = tuple.Item1 * 2;
                Console.CursorTop = tuple.Item2;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(">-");
            }

            else if (tuple == telo.Last() && Smer == 90)
            {
                Console.CursorLeft = tuple.Item1 * 2;
                Console.CursorTop = tuple.Item2;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("S");
            }

            else if (tuple == telo.Last() && Smer == 270)
            {
                Console.CursorLeft = tuple.Item1 * 2;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("S");
            }
        }

        public void SnistJablko(int hadX, int hadY, Jablko jablko, OtraveneJablko otravene, Hra hra)
        {
            if (hadX == otravene.x && hadY == otravene.y)
            {
                Zivy = false;
            }

            else if (hadX == jablko.x && hadY == jablko.y)
            {
                if (Smer == 0)
                {
                    telo.Insert(0, new Tuple<int, int>(telo.Last().Item1 + 1, telo.Last().Item2));
                }

                else if (Smer == 180)
                {
                    telo.Insert(0, new Tuple<int, int>(telo.Last().Item1 - 1, telo.Last().Item2));
                }

                else if (Smer == 270)
                {
                    telo.Insert(0, new Tuple<int, int>(telo.Last().Item1, telo.Last().Item2 + 1));
                }

                else if (Smer == 90)
                {
                    telo.Insert(0, new Tuple<int, int>(telo.Last().Item1, telo.Last().Item2 - 1));
                }

                Console.Beep(1700, 80);
                hra.Score++;
                jablko.Vygenerovat();

            }
        }

        public bool KontrolaJestliNeniHad(Tuple<int, int> cast)
        {
            if (telo.Contains(cast))
            {
                return true;
            }

            else { return false; }

        }
    }
}

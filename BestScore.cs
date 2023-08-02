using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleSnake
{
    class BestScore
    {
        private static string jmenoSouboru = "BestScore.txt";

        public static void AktualizovatBestScore(int score)
        {

            if (File.Exists(BestScore.jmenoSouboru))
            {
                string obsahSouboru = File.ReadAllText(BestScore.jmenoSouboru);
                int ulozeneCislo = int.Parse(obsahSouboru);

                if (ulozeneCislo < score)
                {
                    ulozeneCislo = score;
                    File.WriteAllText(BestScore.jmenoSouboru, ulozeneCislo.ToString());

                }
            }
        }

        public static int BestScoreUlozene()
        {
            string obsahSouboru = File.ReadAllText(BestScore.jmenoSouboru);
            return int.Parse(obsahSouboru);
        }

    }
}

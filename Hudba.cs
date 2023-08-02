using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ConsoleSnake
{
    class Hudba
    {  
        /// <summary>
        /// Spousti hudbu na pozadi v loopu. 
        /// </summary>
        /// <param name="nazevSouboruSHudbou">"GAME_OVER.wav" nebo "SNAKE.wav"</param>
        public static void SpustitHudbu(string nazevSouboruSHudbou)
        {
            SoundPlayer hudbaVPozadi = new SoundPlayer();
            hudbaVPozadi.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + nazevSouboruSHudbou;
            hudbaVPozadi.PlayLooping();
        }
    }
}

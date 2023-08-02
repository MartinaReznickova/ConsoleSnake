using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{

    class OtraveneJablko : Jablko
    {
        public const ConsoleColor barva = ConsoleColor.Green;

        public OtraveneJablko(Jablko jablko, Had had) : base(had)
        {

            this.KontrolaNeniJablko(jablko);
        }

        public void KontrolaNeniJablko(Jablko jablko)
        {
            if (this.y == jablko.y && this.x == jablko.x)
            {
                this.Vygenerovat();
                this.KontrolaNeniJablko(jablko);
            }
        }
    }
}

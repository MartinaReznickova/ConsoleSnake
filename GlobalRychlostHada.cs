using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class GlobalRychlostHada
    {
        private static int indexRychlosti = 0;

        public static int IndexRychlosti()
        {
            return indexRychlosti;
        }

        public static void PrenastavitIndexRychlosti(int index)
        {
            indexRychlosti = index;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    class DummyAI
    {
        public static bool choice(int[,] input, out Tuple<int, int> coordinates)
        {
            coordinates = new Tuple<int, int>(0, 0);
            return true; // true = poke, false = flag
        }
    }
}

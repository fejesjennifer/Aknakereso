using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    public interface IAI
    {
        bool choice(int[,] input, out Tuple<int, int> coordinates); // true = poke, false = fleg
    }
}

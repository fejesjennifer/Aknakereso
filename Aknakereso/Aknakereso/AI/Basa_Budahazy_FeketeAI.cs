using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    class Basa_Budahazy_FeketeAI : IAI
    {

        int x, y;
        public bool choice(int[,] input, out Tuple<int, int> coordinates)
        {
            #region FlagLogicaly
            for (int i = 0; i < input.GetLength(0); i++)
                for (int j = 0; j < input.GetLength(1); j++)
                    if (
                        input[i, j] - AdjacentFlagCount(input, i, j) - AdjacentUnexploredFieldCount(input, i, j) == 0
                        &&
                        AdjacentUnexploredFieldCount(input, i, j) != 0
                        )
                    {
                        x = IndexOfAdjacentUnexploredField(input, i, j).Item1;
                        y = IndexOfAdjacentUnexploredField(input, i, j).Item2;
                        coordinates = new Tuple<int, int>(x, y);
                        return false;
                    }
            #endregion

            #region PokeLogicaly
            for (int i = 0; i < input.GetLength(0); i++)
                for (int j = 0; j < input.GetLength(1); j++)
                    if (
                        input[i, j] - AdjacentFlagCount(input, i, j) == 0
                        &&
                        AdjacentUnexploredFieldCount(input, i, j) != 0
                        )
                    {
                        x = IndexOfAdjacentUnexploredField(input, i, j).Item1;
                        y = IndexOfAdjacentUnexploredField(input, i, j).Item2;
                        coordinates = new Tuple<int, int>(x, y);
                        return true;
                    }
            #endregion

            //todo(ComplicatedFlaging, ComplicatedPokeing);

            #region PokeRandomly
            Random rnd = new Random();
            do
            {
                x = rnd.Next(0, input.GetLength(0));
                y = rnd.Next(0, input.GetLength(1));
            } while (input[x, y] != -1);
            coordinates = new Tuple<int, int>(x, y);
            return true;
            #endregion

        }

        private Tuple<int, int> IndexOfAdjacentUnexploredField(int[,] input, int x, int y)
        {
            int i = x != 0 ? x - 1 : x;
            int n = x != input.GetLength(0) ? x + 1 : x;

            int j = y != 0 ? y - 1 : y;
            int m = y != input.GetLength(1) ? y + 1 : y;

            for (; i <= n; i++)
                for (; j <= m; j++)
                    if (input[i, j] == -1) return new Tuple<int, int>(i, j); ;

            return new Tuple<int, int>(-1, -1);
        }

        private int AdjacentFlagCount(int[,] input, int x, int y)
        {
            int count = 0;

            int i = x != 0 ? x - 1 : x;
            int n = x != input.GetLength(0) ? x + 1 : x;

            int j = y != 0 ? y - 1 : y;
            int m = y != input.GetLength(1) ? y + 1 : y;

            for (; i <= n; i++)
                for (; j <= m; j++)
                    if (input[i, j] == -2) count++;

            return count;
        }

        private int AdjacentUnexploredFieldCount(int[,] input, int x, int y)
        {
            int count = 0;

            int i = x != 0 ? x - 1 : x;
            int n = x != input.GetLength(0) ? x + 1 : x;

            int j = y != 0 ? y - 1 : y;
            int m = y != input.GetLength(1) ? y + 1 : y;

            for (; i <= n; i++)
                for (; j <= m; j++)
                    if (input[i, j] == -1) count++;

            return count;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    public class Aknamezo
    {
        public struct mezo
        {
            public int value;
            public bool visible;
            public bool flagged;

        }

        public enum gameState
        {
            gavenUp,
            inProgress,

            lose,

            won
        };

        mezo[,] Matrix;

        #region Constructors
        public Aknamezo(int n, int m)
        {
            Matrix = new mezo[n, m];
        }

        public Aknamezo(mezo[,] a) : this(a.GetLength(0), a.GetLength(1))
        {
            //            Aknamezo b = new Aknamezo(a.GetLength(0), a.GetLength(1));

            for (int i = 0; i < this.GetLength(0); i++)
            {

                for (int j = 0; j < this.GetLength(1); j++)
                {
                    Matrix[i, j] = a[i, j];
                }
            }
        }
        #endregion

        public int GetLength(int dimension)
        {
            return Matrix.GetLength(dimension);
        }

        public mezo this[int i, int j]
        {
            get { return Matrix[i, j]; }
            set { Matrix[i, j] = value; }
        }

        public gameState WhatIsGameState()
        {
            //Tuple<int, int> coordinates;
            //bool isPoke;
            //DummyAI AI = new DummyAI(); // Change this constructor to chose AI type.
            gameState currentGameState = gameState.won;

            //try { isPoke = AI.choice(GetAknamForAI(), out coordinates); }
            //catch { return gameState.gavenUp; }

            for (int i = 0; i < this.GetLength(0); i++)
                for (int j = 0; j < this.GetLength(1); j++)
                    if (this[i, j].visible == true && this[i, j].value == -1)
                        return gameState.lose;

            for (int i = 0; i < this.GetLength(0); i++)
                for (int j = 0; j < this.GetLength(1); j++)
                    if (this[i, j].visible == false && this[i, j].value != -1)
                        return gameState.inProgress;

            return currentGameState;
        }

        public int[,] GetAknamForAI()
        {
            int m = this.GetLength(0);
            int n = this.GetLength(1);
            int[,] result = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (this[i, j].flagged) result[i, j] = -2;
                    else if (!this[i, j].visible) result[i, j] = -1;
                    else result[i, j] = this[i, j].value;
                }
            return result;
        }

        private void MezoRobbantas(Tuple<int, int> pos)
        {
            if (Matrix[pos.Item1, pos.Item2].visible == false)
            {
                Matrix[pos.Item1, pos.Item2].visible = true;
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        try
                        {
                            if (Matrix[pos.Item1 + i, pos.Item2 + j].visible == false && Matrix[pos.Item1, pos.Item2].value == 0)
                            {
                                MezoRobbantas(new Tuple<int, int>(pos.Item1 + i, pos.Item2 + j));
                            }
                        }
                        catch (IndexOutOfRangeException ex)
                        {

                            continue;
                        }
                        
                    }
                }
            }
        }

        public void MezoFelfed(Tuple<int, int> pos, bool flagged)
        {
            if (flagged)
            {
                Matrix[pos.Item1, pos.Item2].flagged = !Matrix[pos.Item1, pos.Item2].flagged;
                return;
            }

            if (!Matrix[pos.Item1, pos.Item2].flagged)
            {
                if (Matrix[pos.Item1, pos.Item2].value == 0)
                {
                    MezoRobbantas(new Tuple<int, int>(pos.Item1, pos.Item2));
                    return;
                }
                Matrix[pos.Item1, pos.Item2].visible = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    class Aknamezo
    {
        public struct mezo
        {
            public int value;
            public bool visible;
            public bool flagged;

        }

        public enum gameState
        {
            inProgress,
            won,
            lose,
            gavenUp
        };

        mezo[,] Matrix;

        gameState current = gameState.inProgress;

        #region Konstruktorok
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
            Tuple<int, int> coordinates;
            bool isPoke;
            gameState currentGameState = gameState.won;
            
            try
            {
                isPoke = DummyAI.choice(GetAknamForAI(), out coordinates);
            }
            catch
            {
                return gameState.gavenUp;
            }

            if (!isPoke) return gameState.inProgress;

            for (int i = 0; i < this.GetLength(0); i++)
            {
                for (int j = 0; j < this.GetLength(1); j++)
                {
                    if (this[i, j].visible == true && this[i, j].value == -1) 
                    {
                        return gameState.lose;
                    }
                }
            }

            for (int i = 0; i < this.GetLength(0); i++)
            {
                for (int j = 0; j < this.GetLength(1); j++)
                {
                    if (this[i, j].visible == false && this[i, j].value != -1)
                    {
                        return gameState.inProgress;
                    }
                }
            }

            return currentGameState;
           
        }

        

        public int[,] GetAknamForAI()
        {
            int m = this.GetLength(0);
            int n = this.GetLength(1);
            int[,] Return = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (this[i, j].flagged)
                    {
                        Return[i, j] = -2;
                    }
                    else if (!this[i, j].visible)
                    {
                        Return[i, j] = -1;
                    }
                    else Return[i, j] = this[i, j].value;
                }
            }
            return Return;
        }
    }
}

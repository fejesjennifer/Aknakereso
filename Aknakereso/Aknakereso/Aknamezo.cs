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
        
        mezo[,] matrix;
        public Aknamezo(mezo[,] a)
        {
            Aknamezo b = new Aknamezo(a.GetLength(0), a.GetLength(1));

            for (int i = 0; i < b.GetLength(0); i++)
            {

                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = a[i, j];
                }
            }
        }
        // baszas
        // i wanna kill myself! 


        public Aknamezo(int n, int m)
        {
            matrix = new mezo[n, m];


        }
        public mezo[,] getAknamezo(int n, int m)
        {
            mezo[,] a = new mezo[n, m];
            return a;
        }

        public int GetLength(int dimension)
        {
            return matrix.GetLength(dimension);
        }

        public mezo this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public void WhatIsGameState()
        {
            
        }


    }
}

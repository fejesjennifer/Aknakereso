using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aknakereso
{
    static class Saves
    {
        public static void Save(Aknamezo Gamestate, string path)
        {
            StreamWriter f = new StreamWriter(path, false, Encoding.UTF8);
            int m = Gamestate.GetLength(0);
            int n = Gamestate.GetLength(1);
            f.WriteLine(m + ";" + n);
            for (int i = 0; i < m; i++)
            {
                string s = "";
                for (int j = 0; j < n - 1; j++)
                {
                    s += Gamestate[i, j].value + "," + Gamestate[i, j].visible + "," + Gamestate[i, j].flagged + ";";
                }
                s += Gamestate[i, n - 1].value + "," + Gamestate[i, n - 1].visible + "," + Gamestate[i, n - 1].flagged;
                f.WriteLine(s);
            }
            f.Close();
        }

        public static Aknamezo Load(string path)
        {
            StreamReader f = new StreamReader(path);
            string[] s = f.ReadLine().Split(';');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            Aknamezo.mezo[,] Out = new Aknamezo.mezo[m, n];
            for (int i = 0; i < m; i++)
            {
                s = f.ReadLine().Split(';');
                for (int j = 0; j < n; j++)
                {
                    string[] seg = s[j].Split(',');
                    Out[i, j].value = int.Parse(seg[0]);
                    Out[i, j].visible = bool.Parse(seg[1]);
                    Out[i, j].flagged = bool.Parse(seg[2]);
                }
            }
            Aknamezo BeviteliAknamezo = new Aknamezo(Out);
            f.Close();
            return BeviteliAknamezo;
        }

        public static Aknamezo Generate(int height, int width, int mines)
        {
            Aknamezo.mezo[,] Out = new Aknamezo.mezo[height, width];
            int mineCount = 0;
            Random rand = new Random();
            while (mineCount < mines) {
                var pos = new Tuple<int, int>(rand.Next(height), rand.Next(width));
                if (Out[pos.Item1, pos.Item2].value == -1) continue;
                Out[pos.Item1, pos.Item2].value = -1;
                ++mineCount;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; ++j) {
                        try
                        {
                            var m = Out[pos.Item1 + i, pos.Item2 + j];
                            if (m.value != -1) ++m.value;
                        }
                        catch {
                        }
                    }
                }
            }
            Aknamezo retval = new Aknamezo(Out);
            return retval;
        }
    }
}

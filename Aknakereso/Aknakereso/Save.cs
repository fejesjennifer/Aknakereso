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
            int m = Gamestate.getLength(0);
            int n = Gamestate.getLength(1);
            f.WriteLine(m + ";" + n);
            for (int i = 0; i < m; i++)
            {
                string s = "";
                for (int j = 0; j < n - 1; j++)
                {
                }

                f.WriteLine();
            }
            f.Close();
        }
        public static Aknamezo Load(string path)
        {
            StreamReader f = new StreamReader(path);
            string[] s = f.ReadLine().Split(';');
            Aknamezo.mezo[,] Out = new Aknamezo.mezo[int.Parse(s[0]), int.Parse(s[1])];
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
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
    }
}

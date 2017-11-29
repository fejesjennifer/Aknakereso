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
            f.WriteLine(Gamestate.getLengt(0) + " " + Gamestate.getLengt(1));
            f.Close();
        }
        public static Aknamezo Load(string path)
        {
            StreamReader f = new StreamReader(path);
            string[] s = f.ReadLine().Split(';');
            Aknamezo.mezo[,] Out = new Aknamezo.mezo[int.Parse(s[0]), int.Parse(s[1])];
            Aknamezo BeviteliAknamezo = new Aknamezo();
            //aknamező construct f.Readline().Split(' ');
            f.Close();
            return BeviteliAknamezo;
        }
    }
}

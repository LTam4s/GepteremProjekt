using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class Gepterem
    {
        int[,] ertekeles;
        int helyDb;
        string nev;
        int sorDb;

        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }
        public int HelyDb { get => helyDb; set => helyDb = value; }
        public string Nev { get => nev; set => nev = value; }
        public int SorDb { get => sorDb; set => sorDb = value; }

        public Gepterem(int[,] ertekeles, int helyDb, string nev, int sorDb)
        {
            Ertekeles = ertekeles;
            HelyDb = helyDb;
            Nev = nev;
            SorDb = sorDb;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class PetrikLajosSzg
    {
        List<Gepterem> geptermek;

        internal List<Gepterem> Geptermek { get => geptermek; set => geptermek = value; }

        public PetrikLajosSzg(List<Gepterem> geptermek)
        {
            Geptermek = geptermek;
        }
    }
}

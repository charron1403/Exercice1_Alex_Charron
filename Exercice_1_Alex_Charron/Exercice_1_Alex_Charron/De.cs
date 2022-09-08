using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_Alex_Charron
{
    public abstract class De
    {
        internal const int nbFaces = 6;

        public string Type;

        public De()
        {
        }

        public abstract int Brasser();
    }
}

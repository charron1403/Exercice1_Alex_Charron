using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_Alex_Charron
{
    public class De
    {
        internal const int nbFaces = 6;

        public De()
        {
        }

        public virtual int Brasser()
        {
            Random random = new Random();
            return random.Next(1, nbFaces + 1);
        }
    }
}

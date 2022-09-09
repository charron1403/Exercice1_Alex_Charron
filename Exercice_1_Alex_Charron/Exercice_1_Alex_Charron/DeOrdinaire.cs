using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_Alex_Charron
{
    public class DeOrdinaire : De
    {
        public new string Type { get => "ordinaire"; }

        public override int Brasser()
        {
            Random random = new Random();
            return random.Next(1, nbFaces + 1);
        }
    }
}

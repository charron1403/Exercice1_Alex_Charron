using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_Alex_Charron
{
    public class DePipe : De
    {
        public new string Type { get => "pipé"; }
        public DePipe() : base()
        {

        }

        public override int Brasser()
        {
            Random random = new Random();
            int un = random.Next(1, nbFaces + 1);
            int deux = random.Next(1, nbFaces + 1);
            //
            //  regarde le nombre le plus élevé des 2 essais;
            //
            if (un > deux)
            {
                return un;
            }
            else
            {
                return deux;
            }
        }
    }
}

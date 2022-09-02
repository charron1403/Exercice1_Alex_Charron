using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_Alex_Charron
{
    public class Controleur
    {
        private De deCourant;
        private string[] lstTypeDes = {"normal", "pipé"};
        private int totalResultatDes;

        public int TotalResultatDes { get => totalResultatDes; }

        public void GenererDeAuHasard(out string typeDe)
        {
            Random random = new Random();
            if (lstTypeDes[random.Next(2)] == "normal")
            {
                deCourant = new De();
                typeDe = "normal";
            }
            else
            {
                deCourant = new DePipe();
                typeDe = "pipé";
            }
        }

        public int BrasserDe()
        {
            int resultatDes = deCourant.Brasser();
            totalResultatDes += resultatDes;
            return resultatDes;
        }
    }
}

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

        public string GenererDeAuHasard()
        {
            Random random = new Random();
            if (lstTypeDes[random.Next(2)] == "normal")
            {
                deCourant = new DeOrdinaire();
                return ((DeOrdinaire)deCourant).Type;
            }
            else
            {
                deCourant = new DePipe();
                return ((DePipe)deCourant).Type;
            }
        }

        public int BrasserDe(out string typeDe)
        {
            typeDe = GenererDeAuHasard();
            int resultatDes = deCourant.Brasser();
            totalResultatDes += resultatDes;
            return resultatDes;
        }
    }
}

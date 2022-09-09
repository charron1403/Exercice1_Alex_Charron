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
        private DeOrdinaire deOrdinaire;
        private DePipe dePipe;
        private string[] lstTypeDes = {"normal", "pipé"};
        private int totalResultatDes;

        public int TotalResultatDes { get => totalResultatDes; }

        public Controleur()
        {
            deOrdinaire = new DeOrdinaire();
            dePipe = new DePipe();
        }

        public string GenererDeAuHasard()
        {
            Random random = new Random();
            if (lstTypeDes[random.Next(2)] == "normal")
            {
                deCourant = deOrdinaire;
                return ((DeOrdinaire)deCourant).Type;
            }
            else
            {
                deCourant = dePipe;
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

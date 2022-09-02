using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_1_Alex_Charron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Controleur controleur;

        private void Form1_Load(object sender, EventArgs e)
        {
            controleur = new Controleur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MettreAJourAffichage();
        }

        private void MettreAJourAffichage()
        {
            string type;
            controleur.GenererDeAuHasard(out type);
            txtType.Text = "Type du dé: " + type;
            txtValeur.Text = "Valeur du dé: " + controleur.BrasserDe().ToString();
            txtTotal.Text = "Total: " + controleur.TotalResultatDes.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThé
{
    class Commande
    {
        int NumeroComande;
        DateTime DateCommande;
        DateTime HeureCommande;
        Serveur CodeServeur;

        public Commande(int numeroComande, DateTime dateCommande, DateTime heureCommande, Serveur code)
        {
            NumeroComande = numeroComande;
            DateCommande = dateCommande;
            HeureCommande = heureCommande;
            this.CodeServeur = code;
        }

        public int NumeroComande1 { get => NumeroComande; set => NumeroComande = value; }
        public DateTime DateCommande1 { get => DateCommande; set => DateCommande = value; }
        public DateTime HeureCommande1 { get => HeureCommande; set => HeureCommande = value; }
        internal Serveur CodeServeur1 { get => CodeServeur; set => CodeServeur = value; }
    }
 
}

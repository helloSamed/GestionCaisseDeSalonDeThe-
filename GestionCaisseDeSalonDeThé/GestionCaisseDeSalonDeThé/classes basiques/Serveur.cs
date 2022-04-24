using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThé
{
    class Serveur
    {
        int CodeServeur;
        string nomServeur;

        public Serveur(int codeServeur, string nomServeur)
        {
            CodeServeur1 = codeServeur;
            this.NomServeur = nomServeur;
        }

        public int CodeServeur1 { get => CodeServeur; set => CodeServeur = value; }
        public string NomServeur { get => nomServeur; set => nomServeur = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThé
{
    class Recette
    {
        int CodeRecette;
        DateTime DateJourne;
        Serveur CodeServeur;
        int NombreRecette;

        public Recette(int codeRecette, DateTime dateJourne, int codeServeur, int nombreRecette)
        {
            CodeRecette = codeRecette;
            DateJourne = dateJourne;
            CodeServeur.CodeServeur1 = codeServeur;
            NombreRecette = nombreRecette;
        }

        public int CodeRecette1 { get => CodeRecette; set => CodeRecette = value; }
        public DateTime DateJourne1 { get => DateJourne; set => DateJourne = value; }
        public int NombreRecette1 { get => NombreRecette; set => NombreRecette = value; }
        internal Serveur CodeServeur1 { get => CodeServeur; set => CodeServeur = value; }
    }
}

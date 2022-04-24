using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThé
{
    class Boisson
    {
        int CodeBoisson;
        String désignation;
        float prix;
        int quantiteStock;

        public Boisson(int codeBoisson, string désignation, float prix, int quantiteStock)
        {
            CodeBoisson1 = codeBoisson;
            this.Désignation = désignation;
            this.Prix = prix;
            this.QuantiteStock = quantiteStock;
        }

        public int CodeBoisson1 { get => CodeBoisson; set => CodeBoisson = value; }
        public string Désignation { get => désignation; set => désignation = value; }
        public float Prix { get => prix; set => prix = value; }
        public int QuantiteStock { get => quantiteStock; set => quantiteStock = value; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCaisseDeSalonDeThé.Gestion_serveur;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace GestionCaisseDeSalonDeThé
   
{
    public partial class GestionServeurs : MetroForm
    {
        public GestionServeurs()
        {
            InitializeComponent();
        }

        private void GestionServeurs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Gestion_serveur.AjouterServeur S1 = new Gestion_serveur.AjouterServeur();
            S1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestion_serveur.RechercherServeur S1 = new Gestion_serveur.RechercherServeur();
            S1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gestion_serveur.ModifierServeur S1 = new Gestion_serveur.ModifierServeur();
            S1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gestion_serveur.ListerServeur S1 = new Gestion_serveur.ListerServeur();
            S1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gestion_serveur.SupprimerServeur S1 = new Gestion_serveur.SupprimerServeur();
            S1.ShowDialog();
        }
    }
}

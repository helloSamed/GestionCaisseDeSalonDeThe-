using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCaisseDeSalonDeThé.Gestion_commande;
using MetroFramework.Forms;

namespace GestionCaisseDeSalonDeThé
{
    public partial class GestionCommande : MetroForm
    {
        public GestionCommande()
        {
            InitializeComponent();
        }

        private void GestionCommande_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterCommande  C1 = new Gestion_commande.AjouterCommande();
            C1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RechercherCommande C1 = new RechercherCommande();
            C1.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModifierCommandes C1 = new  ModifierCommandes();
            C1.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ListerCommandes C1 = new ListerCommandes();
            C1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupprimerCommande C1 = new SupprimerCommande();
            C1.ShowDialog();

        }
    }
}

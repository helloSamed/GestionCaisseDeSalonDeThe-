using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCaisseDeSalonDeThé.Gestion_Recette;
using MetroFramework.Forms;

namespace GestionCaisseDeSalonDeThé
{
    public partial class GestionRecette : MetroForm
    {
        public GestionRecette()
        {
            InitializeComponent();
        }

        private void GestionRecette_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterRecette R1 = new AjouterRecette();
            R1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RechercherRecette R1 = new RechercherRecette();
            R1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModifierRecette R1 = new ModifierRecette();
            R1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           ListerRecettes R1 = new ListerRecettes();
            R1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupprimerRecette R1 = new SupprimerRecette();
            R1.ShowDialog();
        }
    }
}

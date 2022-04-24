using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCaisseDeSalonDeThé.Gestion_boisson;
using MetroFramework.Forms;

namespace GestionCaisseDeSalonDeThé
{
    public partial class Gestion_Boisson : MetroForm
    {
        public Gestion_Boisson()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterBoisson B1 = new AjouterBoisson();
            B1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        { RechercherBoisson B1   = new RechercherBoisson();
            B1.ShowDialog();
        }

        private void Gestion_Boisson_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModifierBoisson B1 = new ModifierBoisson();
            B1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           ListerBoisson B1 = new ListerBoisson();
            B1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupprimerBoisson B1 = new SupprimerBoisson();
            B1.ShowDialog();
        }
    }
}

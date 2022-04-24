using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GestionCaisseDeSalonDeThé
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionCommande C = new GestionCommande();
            C.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionRecette R= new GestionRecette();
            R.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           Gestion_Boisson B = new Gestion_Boisson();
            B.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionServeurs S = new GestionServeurs();
            S.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

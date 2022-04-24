using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using MetroFramework.Forms;
namespace GestionCaisseDeSalonDeThé.Gestion_serveur
{
    public partial class AjouterServeur : MetroForm

    {
        requêttes.Serveurs BD = new requêttes.Serveurs();
        public AjouterServeur()
        {
            InitializeComponent();
        }

        private void AjouterServeur_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Veuillez remplir les zones de textes nécessaires", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BD.addServeur(int.Parse(textBox1.Text), textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}

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

namespace GestionCaisseDeSalonDeThé.Gestion_serveur
{
    public partial class SupprimerServeur : MetroForm
    {
        requêttes.Serveurs BD = new requêttes.Serveurs();
        public SupprimerServeur()
        {
            InitializeComponent();
        }

        private void SupprimerServeur_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Veuillez remplir la zone de texte par un code de serveur.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BD.deleteServeur(int.Parse(textBox1.Text));
                textBox1.Clear();
            }
        }
    }
}

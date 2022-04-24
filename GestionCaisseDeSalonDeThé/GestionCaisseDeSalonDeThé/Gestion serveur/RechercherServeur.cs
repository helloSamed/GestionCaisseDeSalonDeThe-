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
using System.Data.Common;
using System.Data.SqlClient;

namespace GestionCaisseDeSalonDeThé.Gestion_serveur
{
    public partial class RechercherServeur : MetroForm
    {
        requêttes.Serveurs BD = new requêttes.Serveurs();
        public RechercherServeur()
        {
            InitializeComponent();
        }

        private void RechercherServeur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlD = BD.searchServeur(int.Parse(textBox1.Text));
            DataTable dtbl = new DataTable();
            sqlD.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }
    }
}

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
using System.Data.SqlClient;


namespace GestionCaisseDeSalonDeThé.Gestion_commande
{
    public partial class SupprimerCommande : MetroForm
    {
        public SupprimerCommande()
        {
            InitializeComponent();
        }

        private void SupprimerCommande_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = true";
            try
            {
                con.Open();

                SqlCommand com1 = new SqlCommand();
                com1.Connection = con;
                com1.CommandText = "DELETE BoissonCommande FROM BoissonCommande INNER JOIN Commande ON BoissonCommande.Code_Serveur = Commande.Code_Serveur WHERE Commande.numeroCommande = " + int.Parse(textBox1.Text);
                com1.ExecuteNonQuery();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "DELETE FROM COMMANDE WHERE numeroCom = " + int.Parse(textBox1.Text);
                com.ExecuteNonQuery();



                MessageBox.Show("Commande supprimé", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();

            }
            catch (Exception) { }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }

}


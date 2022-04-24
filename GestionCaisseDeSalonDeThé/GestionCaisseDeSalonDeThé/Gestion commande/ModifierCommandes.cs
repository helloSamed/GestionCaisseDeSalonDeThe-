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
    public partial class ModifierCommandes : MetroForm
    {
        public ModifierCommandes()
        {
            InitializeComponent();
        }

        private void ModifierCommandes_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = true";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT * FROM BOISSON";
                SqlDataReader reader = com.ExecuteReader();
                listBox1.Items.Clear();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[1].ToString());
                }
                reader.Close();

                SqlCommand com1 = new SqlCommand();
                com1.Connection = con;
                com1.CommandText = "SELECT * FROM SERVEUR";
                SqlDataReader reader1 = com1.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader1.Read())
                {
                    comboBox1.Items.Add(reader1[1].ToString());
                }
                reader.Close();

            }
            catch (Exception)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = true";
            try
            {
                con.Open();
                //Récupérer code boisson
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT CodeBoiss FROM BOISSON WHERE Designation = '" + listBox1.SelectedItem.ToString() + "'";
                int code = (int)com.ExecuteScalar();
                //Récupérer code serveur
                SqlCommand com2 = new SqlCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT codeServeur FROM SERVEUR WHERE Nom_Serveur = '" + comboBox1.SelectedItem.ToString() + "'";
                int codee = (int)com2.ExecuteScalar();

                SqlCommand com1 = new SqlCommand();
                com1.Connection = con;
                com1.CommandText = "INSERT INTO BOISSONCOMMANDE VALUES(" + codee + ", " + code + ", " + int.Parse(textBox3.Text) + ")";
                com1.ExecuteNonQuery();
                listBox1.ClearSelected();
                textBox3.Clear();

            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = true";
            try
            {
                con.Open();

                //Récupérer code boisson
                SqlCommand com1 = new SqlCommand();
                com1.Connection = con;
                com1.CommandText = "SELECT codeBoiss FROM BOISSONS WHERE Désignation = '" + listBox1.SelectedItem.ToString() + "'";
                int code = (int)com1.ExecuteScalar();
                //Récupérer code serveur
                SqlCommand com2 = new SqlCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT codeServeur FROM SERVEURS WHERE Nom_Serveur = '" + comboBox1.SelectedItem.ToString() + "'";
                int codee = (int)com2.ExecuteScalar();

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "UPDATE BoissonCommande SET qteCommandé = qteCommandé + " + int.Parse(textBox3.Text) + " WHERE Code_Serveur = " + codee + " AND Code_Boisson = " + code;
                com.ExecuteNonQuery();

                textBox3.Clear();
                listBox1.ClearSelected();
            }
            catch (Exception)
            {
            }
        }
    }
}

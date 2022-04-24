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
using System.Data.SqlTypes;

namespace GestionCaisseDeSalonDeThé.Gestion_commande
{
    public partial class AjouterCommande : MetroForm
    {
        public AjouterCommande()
        {
            InitializeComponent();
        }

        private void AjouterCommande_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = true";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                SqlCommand com1 = new SqlCommand();
                com.Connection = con;
                com1.Connection = con;


                com1.CommandText = "SELECT Code_Serveur FROM SERVEUR WHERE Nom_Serveur = '" + comboBox1.SelectedItem.ToString() + "'";
                int codee = (int)com1.ExecuteScalar();


                com.CommandText = "INSERT INTO COMMANDE VALUES(" + int.Parse(textBox1.Text) + ", '" + DateTime.Parse(dateTimePicker1.Text).ToShortDateString() + "', '" + DateTime.Now + "', " + codee + ")";
                com.ExecuteNonQuery();
                MessageBox.Show("Commande ajouté", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                dateTimePicker1.Refresh();
                textBox3.Clear();
                textBox1.Focus();

            }
            catch (Exception)
            {
                MessageBox.Show("Commande refusé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

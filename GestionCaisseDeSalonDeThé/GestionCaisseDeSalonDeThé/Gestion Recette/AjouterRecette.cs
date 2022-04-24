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

namespace GestionCaisseDeSalonDeThé.Gestion_Recette
{
    public partial class AjouterRecette : MetroForm
    {
        public AjouterRecette()
        {
            InitializeComponent();
        }

        private void AjouterRecette_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT * FROM SERVEURS";
                SqlDataReader reader = com.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[1].ToString());
                }
                reader.Close();

            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"";
            try
            {
                con.Open();
                SqlCommand com1 = new SqlCommand();
                com1.Connection = con;
                com1.CommandText = "SELECT codeServeur FROM SERVEUR WHERE Nom = '" + comboBox1.SelectedItem.ToString() + "'";
                int code = (int)com1.ExecuteScalar();


                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT COUNT(*) FROM BoissonCommande WHERE codeServeur = " + code;
                int nr = (int)com.ExecuteScalar(); //ExecuteScalar retourne une valeur 

                com.CommandText = "INSERT INTO RECETTE VALUES(" + int.Parse(textBox1.Text) + ", '" + DateTime.Parse(dateTimePicker1.Text).ToShortDateString() + "', " + nr + ", " + code + ")";
                com.ExecuteNonQuery();
                MessageBox.Show("Recette ajouté", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                dateTimePicker1.Refresh();
                comboBox1.SelectedIndex = -1;
                textBox1.Focus();

            }
            catch (Exception) { }
        }
    }     }
    


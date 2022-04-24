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
    public partial class SupprimerRecette : MetroForm
    {
        public SupprimerRecette()
        {
            InitializeComponent();
        }

        private void SupprimerRecette_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"";
            try
            {
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "DELETE FROM RECETTES WHERE Code_Recette = " + int.Parse(textBox1.Text);
                com.ExecuteNonQuery();



                MessageBox.Show("Recette supprimé", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();

            }
            catch (Exception) { }
        }
    }
}

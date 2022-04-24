using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionCaisseDeSalonDeThé.requêttes
{
    class Boissons
    {

        public void addBoisson(int CodeBoisson, string designation, float prix, int quantiteStock)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Area 51\ESISA\3eme anne\C#\S6\PROJECTSQL\db\Caisse.mdf;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "INSERT INTO Boissons VALUES('" + designation + "'," + prix + "," + quantiteStock +  ")";
                com.ExecuteNonQuery();
                MessageBox.Show("Boisson ajouté", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception) { }
        }

    }
}

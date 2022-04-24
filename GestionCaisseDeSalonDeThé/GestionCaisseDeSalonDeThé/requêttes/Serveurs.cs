using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionCaisseDeSalonDeThé.requêttes
{
    class Serveurs
    {

        public void addServeur(int CodeServeur, string NomServeur)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "INSERT INTO Serveur VALUES(" + CodeServeur + ", '" + NomServeur + "')";
                com.ExecuteNonQuery();
                MessageBox.Show("Serveur ajouté", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Ce serveur existe deja, veuillez saisir un nouveau code de serveur.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deleteServeur(int CodeServeur)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Studies\3B\C#\TPSQL\TPSQL\Database1.mdf;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "DELETE FROM SERVEUR WHERE Code_Serveur = " + CodeServeur;
                com.ExecuteNonQuery();
                MessageBox.Show("Serveur supprimé", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ce serveur n'existe pas, veuillez saisir le code d'un serveur existant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SqlDataAdapter searchServeur(int CodeServeur)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                SqlDataAdapter sqlD = new SqlDataAdapter("SELECT * FROM Serveurs WHERE Code_Serveur = " + CodeServeur, con);
                return sqlD;

            }
            catch (Exception)
            {
                MessageBox.Show("Ce serveur n'existe pas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void updateServeur(int CodeServeur, string NomServeur)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "UPDATE SERVEUR SET Nom_Serveur = '" + NomServeur + "' WHERE codeServeur = " + CodeServeur;
                com.ExecuteNonQuery();
                MessageBox.Show("Serveur modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
            }
        }

        public SqlDataAdapter ListServeur()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                SqlDataAdapter sqlD = new SqlDataAdapter("SELECT * FROM Serveur", con);
                return sqlD;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

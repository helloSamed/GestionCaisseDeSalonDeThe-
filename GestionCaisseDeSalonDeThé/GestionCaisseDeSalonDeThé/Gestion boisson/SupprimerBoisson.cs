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

namespace GestionCaisseDeSalonDeThé
{
    public partial class SupprimerBoisson : MetroForm
    {
        public SupprimerBoisson()
        {
            InitializeComponent();
        }

        private void SupprimerBoisson_Load(object sender, EventArgs e)
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
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Area 51\ESISA\3eme anne\C#\S6\PROJECTSQL\db\Caisse.mdf;Integrated Security=True";
            try
            {
                con.Open();
               
                SqlCommand com1 = new SqlCommand();
         
                com1.Connection = con;
             
                com1.CommandText = "DELETE FROM Boissons WHERE codedelaboisson=  " + Convert.ToInt32(textBox2.Text);
                 MessageBox.Show("Boisson supprimé", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                com1.ExecuteNonQuery();
                textBox2.Clear();
                textBox2.Focus();
            }
            catch (Exception)
            {
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

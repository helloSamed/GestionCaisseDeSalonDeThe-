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
namespace GestionCaisseDeSalonDeThé.Gestion_boisson
{
    public partial class ListerBoisson : MetroForm
    {
        public ListerBoisson()
        {
            InitializeComponent();
        }

        private void ListerBoisson_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Area 51\ESISA\3eme anne\C#\S6\PROJECTSQL\db\Caisse.mdf;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                SqlDataAdapter sqlD = new SqlDataAdapter("SELECT * FROM Boissons", con);
                DataTable dtbl = new DataTable();
                sqlD.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

            }
            catch (Exception) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


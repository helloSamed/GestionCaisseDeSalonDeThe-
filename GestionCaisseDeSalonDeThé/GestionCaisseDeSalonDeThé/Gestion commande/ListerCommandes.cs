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
    public partial class ListerCommandes : MetroForm
    {
        public ListerCommandes()
        {
            InitializeComponent();
        }

        private void ListerCommandes_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = true";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                SqlDataAdapter sqlD = new SqlDataAdapter("SELECT * FROM COMMANDE", con);
                DataTable dtbl = new DataTable();
                sqlD.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

            }
            catch (Exception) { }
        }
    }
}

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
    public partial class RechercherBoisson : MetroForm
    {
        public RechercherBoisson()
        {
            InitializeComponent();
        }

        private void RechercherBoisson_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = true";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                SqlDataAdapter sqlD = new SqlDataAdapter("SELECT * FROM Boissons WHERE codedelaboisson = " + int.Parse(textBox2.Text), con);
                DataTable dtbl = new DataTable();
                sqlD.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

            }
            catch (Exception) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.DataSource = null;
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

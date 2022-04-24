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
    public partial class ModifierBoisson : MetroForm
    {
        public ModifierBoisson()
        {
            InitializeComponent();
        }

        private void ModifierBoisson_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Area 51\ESISA\3eme anne\C#\S6\PROJECTSQL\db\Caisse.mdf;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "UPDATE Boissons SET désignation = '" + textBox4.Text + "' , prix = " + float.Parse(textBox3.Text) + " , qteStock = "
                    + int.Parse(textBox5.Text) + " WHERE codedelaboisson = " + int.Parse(textBox2.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Boisson modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

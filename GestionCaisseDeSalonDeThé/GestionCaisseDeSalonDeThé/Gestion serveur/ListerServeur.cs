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

namespace GestionCaisseDeSalonDeThé.Gestion_serveur
{
    public partial class ListerServeur : MetroForm
    {
        requêttes.Serveurs BD = new requêttes.Serveurs();
        public ListerServeur()
        {
            InitializeComponent();
        }

        private void ListerServeur_Load(object sender, EventArgs e)
        {

            SqlDataAdapter sqlD = BD.ListServeur();
            DataTable dtbl = new DataTable();
            sqlD.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }
    }
    
}

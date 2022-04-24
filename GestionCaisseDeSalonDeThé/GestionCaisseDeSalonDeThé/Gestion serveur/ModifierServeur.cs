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

namespace GestionCaisseDeSalonDeThé.Gestion_serveur
{
    public partial class ModifierServeur : MetroForm
    {
        requêttes.Serveurs BD = new requêttes.Serveurs();
        public ModifierServeur()
        {
            InitializeComponent();
        }

        private void ModifierRecette_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            BD.updateServeur(int.Parse(textBox1.Text), textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}

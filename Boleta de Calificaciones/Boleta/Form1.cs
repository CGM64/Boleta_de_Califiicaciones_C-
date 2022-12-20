using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace Boleta
{
    public partial class Form1 : Form
    {
        MostrarBoleta mostrarBoleta; 

        public Form1()
        {
            InitializeComponent();

            mostrarBoleta = new MostrarBoleta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarBoleta.agregarNotas(
                Convert.ToInt16(txtC.Text),
                txtEstudiante.Text,
                float.Parse(txtMatemáticas.Text),
                float.Parse(txtIdiomaE.Text),
                float.Parse(txtCSociales.Text),
                float.Parse(txtCNaturales.Text));

            dtgBoleta.DataSource = mostrarBoleta.calculosNotas.ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtC.Clear();
            txtEstudiante.Clear();
            txtMatemáticas.Clear();
            txtIdiomaE.Clear();
            txtCSociales.Clear();
            txtCNaturales.Clear();
        }
    }
}

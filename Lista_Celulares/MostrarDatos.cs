using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Celulares
{
    public partial class MostrarDatos : Form
    {
        public Celulares celulares = new Celulares();
        public MostrarDatos()
        {
            InitializeComponent();
        }
        private void btnBuscarModelo_Click(object sender, EventArgs e)
        {
            dgvModelo.DataSource = celulares.CelularXModelo(txtModel.Text);
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            MostrarCelulares mostrarCelulares = new MostrarCelulares();
            mostrarCelulares.Show();
            this.Hide();
            mostrarCelulares.celulares = celulares;
        }
    }
}
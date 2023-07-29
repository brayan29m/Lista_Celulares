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
    public partial class IngresarDatos : Form
    {
        Celulares celulares = new Celulares();
        public IngresarDatos()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Celular celular = new Celular();
            celular.Marca = cmbMarca.SelectedItem.ToString();
            celular.Modelo = txtModelo.Text;
            celular.Precio = mtxtPrecio.Text;
            celular.Anio = Convert.ToInt32(mtxtAnio.Text);
            celulares.Agregar(celular);
            MessageBox.Show("Datos almacenados correctamente");
            Limpiar();
            dgvDatos.DataSource = celulares.ImprimirCelulares();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MostrarDatos mostrarDatos = new MostrarDatos();
            mostrarDatos.Show();
            this.Hide();
            mostrarDatos.celulares = celulares;
        }
        public void Limpiar()
        {
            txtModelo.Clear();
            mtxtPrecio.Clear();
            mtxtAnio.Clear();
            cmbMarca.ResetText();
        }
    }
}

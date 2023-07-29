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
    public partial class MostrarCelulares : Form
    {
        public Celulares celulares = new Celulares();
        public MostrarCelulares()
        {
            InitializeComponent();
        }

        private void btnAnio_Click(object sender, EventArgs e)
        {
            dgvAnio.DataSource = celulares.CelularXAnio(Convert.ToInt32(mskAnio.Text));
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            dgvMarca.DataSource = celulares.CelularXMarca(txtMarca.Text);
        }
    }
}

namespace Lista_Celulares
{
    partial class IngresarDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtAnio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.mtxtPrecio = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(26, 182);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(144, 182);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(277, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(445, 250);
            this.dgvDatos.TabIndex = 2;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Xiaomi",
            "iPhone",
            "Samsung",
            "Huawei",
            "Honor",
            "Realme",
            "Infinix",
            "Nokia",
            "Tecno",
            "HTC",
            "Motorola",
            "Nubia",
            "Oppo",
            "Sony",
            "UmiDIGI",
            "ZTE"});
            this.cmbMarca.Location = new System.Drawing.Point(98, 20);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca:";
            // 
            // mtxtAnio
            // 
            this.mtxtAnio.Location = new System.Drawing.Point(98, 137);
            this.mtxtAnio.Mask = "9999";
            this.mtxtAnio.Name = "mtxtAnio";
            this.mtxtAnio.Size = new System.Drawing.Size(100, 20);
            this.mtxtAnio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Año:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(98, 60);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 10;
            // 
            // mtxtPrecio
            // 
            this.mtxtPrecio.Location = new System.Drawing.Point(98, 97);
            this.mtxtPrecio.Mask = "$9999.99";
            this.mtxtPrecio.Name = "mtxtPrecio";
            this.mtxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.mtxtPrecio.TabIndex = 11;
            // 
            // IngresarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 286);
            this.Controls.Add(this.mtxtPrecio);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnGuardar);
            this.Name = "IngresarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.MaskedTextBox mtxtPrecio;
    }
}


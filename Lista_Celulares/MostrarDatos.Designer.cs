
namespace Lista_Celulares
{
    partial class MostrarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnBuscarModelo = new System.Windows.Forms.Button();
            this.dgvModelo = new System.Windows.Forms.DataGridView();
            this.btnModelos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(63, 12);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 1;
            // 
            // btnBuscarModelo
            // 
            this.btnBuscarModelo.Location = new System.Drawing.Point(169, 10);
            this.btnBuscarModelo.Name = "btnBuscarModelo";
            this.btnBuscarModelo.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarModelo.TabIndex = 2;
            this.btnBuscarModelo.Text = "Buscar Modelo";
            this.btnBuscarModelo.UseVisualStyleBackColor = true;
            this.btnBuscarModelo.Click += new System.EventHandler(this.btnBuscarModelo_Click);
            // 
            // dgvModelo
            // 
            this.dgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelo.Location = new System.Drawing.Point(12, 41);
            this.dgvModelo.Name = "dgvModelo";
            this.dgvModelo.Size = new System.Drawing.Size(445, 250);
            this.dgvModelo.TabIndex = 3;
            // 
            // btnModelos
            // 
            this.btnModelos.Location = new System.Drawing.Point(357, 9);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(100, 23);
            this.btnModelos.TabIndex = 4;
            this.btnModelos.Text = "Siguiente";
            this.btnModelos.UseVisualStyleBackColor = true;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 311);
            this.Controls.Add(this.btnModelos);
            this.Controls.Add(this.dgvModelo);
            this.Controls.Add(this.btnBuscarModelo);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label1);
            this.Name = "MostrarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnBuscarModelo;
        private System.Windows.Forms.DataGridView dgvModelo;
        private System.Windows.Forms.Button btnModelos;
    }
}
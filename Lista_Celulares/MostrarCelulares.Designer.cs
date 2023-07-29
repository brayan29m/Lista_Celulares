
namespace Lista_Celulares
{
    partial class MostrarCelulares
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
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.dgvAnio = new System.Windows.Forms.DataGridView();
            this.btnAnio = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.mskAnio = new System.Windows.Forms.MaskedTextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(12, 51);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(445, 150);
            this.dgvMarca.TabIndex = 0;
            // 
            // dgvAnio
            // 
            this.dgvAnio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnio.Location = new System.Drawing.Point(12, 249);
            this.dgvAnio.Name = "dgvAnio";
            this.dgvAnio.Size = new System.Drawing.Size(445, 150);
            this.dgvAnio.TabIndex = 1;
            // 
            // btnAnio
            // 
            this.btnAnio.Location = new System.Drawing.Point(152, 220);
            this.btnAnio.Name = "btnAnio";
            this.btnAnio.Size = new System.Drawing.Size(100, 23);
            this.btnAnio.TabIndex = 2;
            this.btnAnio.Text = "Mostrar";
            this.btnAnio.UseVisualStyleBackColor = true;
            this.btnAnio.Click += new System.EventHandler(this.btnAnio_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(152, 22);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(100, 23);
            this.btnMarca.TabIndex = 3;
            this.btnMarca.Text = "Mostrar";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // mskAnio
            // 
            this.mskAnio.Location = new System.Drawing.Point(12, 223);
            this.mskAnio.Mask = "9999";
            this.mskAnio.Name = "mskAnio";
            this.mskAnio.Size = new System.Drawing.Size(100, 20);
            this.mskAnio.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 25);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Año";
            // 
            // MostrarCelulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.mskAnio);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnAnio);
            this.Controls.Add(this.dgvAnio);
            this.Controls.Add(this.dgvMarca);
            this.Name = "MostrarCelulares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarCelulares";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.DataGridView dgvAnio;
        private System.Windows.Forms.Button btnAnio;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.MaskedTextBox mskAnio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
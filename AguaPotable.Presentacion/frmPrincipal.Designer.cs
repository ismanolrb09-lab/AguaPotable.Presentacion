namespace AguaPotable.Presentacion
{
    partial class frmPrincipal
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMedidores = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnCortes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(216, 107);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(317, 28);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMedidores
            // 
            this.btnMedidores.Location = new System.Drawing.Point(216, 160);
            this.btnMedidores.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedidores.Name = "btnMedidores";
            this.btnMedidores.Size = new System.Drawing.Size(317, 28);
            this.btnMedidores.TabIndex = 1;
            this.btnMedidores.Text = "MEDIDORES";
            this.btnMedidores.UseVisualStyleBackColor = true;
            this.btnMedidores.Click += new System.EventHandler(this.btnMedidores_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(216, 208);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(317, 28);
            this.btnFacturacion.TabIndex = 2;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnCortes
            // 
            this.btnCortes.Location = new System.Drawing.Point(216, 261);
            this.btnCortes.Margin = new System.Windows.Forms.Padding(4);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(317, 28);
            this.btnCortes.TabIndex = 3;
            this.btnCortes.Text = "CORTES";
            this.btnCortes.UseVisualStyleBackColor = true;
            this.btnCortes.Click += new System.EventHandler(this.btnCortes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(216, 313);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(317, 28);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCortes);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnMedidores);
            this.Controls.Add(this.btnClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Agua Potable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMedidores;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnCortes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}
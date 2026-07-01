namespace AguaPotable.Presentacion
{
    partial class frmCortes
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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTipoOrden = new System.Windows.Forms.ComboBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.dgvCortes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(160, 97);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(265, 24);
            this.cmbCliente.TabIndex = 0;
            // 
            // cmbTipoOrden
            // 
            this.cmbTipoOrden.FormattingEnabled = true;
            this.cmbTipoOrden.Location = new System.Drawing.Point(160, 159);
            this.cmbTipoOrden.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoOrden.Name = "cmbTipoOrden";
            this.cmbTipoOrden.Size = new System.Drawing.Size(265, 24);
            this.cmbTipoOrden.TabIndex = 1;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(160, 201);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.MaxLength = 200;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(298, 137);
            this.txtMotivo.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrar.Location = new System.Drawing.Point(90, 400);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(147, 40);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Location = new System.Drawing.Point(259, 400);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(139, 40);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "EJECUTAR";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnPendientes
            // 
            this.btnPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendientes.Location = new System.Drawing.Point(90, 448);
            this.btnPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(307, 28);
            this.btnPendientes.TabIndex = 5;
            this.btnPendientes.Text = " VER CORTES PENDIENTES";
            this.btnPendientes.UseVisualStyleBackColor = false;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // dgvCortes
            // 
            this.dgvCortes.AllowUserToAddRows = false;
            this.dgvCortes.AllowUserToDeleteRows = false;
            this.dgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCortes.Location = new System.Drawing.Point(503, 22);
            this.dgvCortes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCortes.MultiSelect = false;
            this.dgvCortes.Name = "dgvCortes";
            this.dgvCortes.ReadOnly = true;
            this.dgvCortes.RowHeadersWidth = 51;
            this.dgvCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCortes.Size = new System.Drawing.Size(519, 482);
            this.dgvCortes.TabIndex = 6;
            this.dgvCortes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCortes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "CLIENTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "TIPO DE ORDEN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "GESTOR DE CORTES DE SERVICIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "MOTIVO:";
            // 
            // frmCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCortes);
            this.Controls.Add(this.btnPendientes);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.cmbTipoOrden);
            this.Controls.Add(this.cmbCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCortes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.frmCortes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTipoOrden;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dgvCortes;
        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
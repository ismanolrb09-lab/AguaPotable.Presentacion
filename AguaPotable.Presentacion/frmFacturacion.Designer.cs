namespace AguaPotable.Presentacion
{
    partial class frmFacturacion
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnVencidas = new System.Windows.Forms.Button();
            this.btnVerTodas = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(176, 100);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(257, 24);
            this.cmbCliente.TabIndex = 0;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(176, 145);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(257, 24);
            this.cmbTipo.TabIndex = 1;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(262, 196);
            this.txtConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsumo.MaxLength = 20;
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(171, 22);
            this.txtConsumo.TabIndex = 2;
            this.txtConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsumo_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(262, 238);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(171, 22);
            this.txtTotal.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(109)))), ((int)(((byte)(164)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(55, 359);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnEmitir
            // 
            this.btnEmitir.BackColor = System.Drawing.Color.Chartreuse;
            this.btnEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitir.Location = new System.Drawing.Point(186, 359);
            this.btnEmitir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(100, 28);
            this.btnEmitir.TabIndex = 5;
            this.btnEmitir.Text = "EMITIR";
            this.btnEmitir.UseVisualStyleBackColor = false;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(315, 359);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(100, 28);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnVencidas
            // 
            this.btnVencidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVencidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVencidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencidas.Location = new System.Drawing.Point(55, 425);
            this.btnVencidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVencidas.Name = "btnVencidas";
            this.btnVencidas.Size = new System.Drawing.Size(127, 28);
            this.btnVencidas.TabIndex = 7;
            this.btnVencidas.Text = "VENCIDAS";
            this.btnVencidas.UseVisualStyleBackColor = false;
            this.btnVencidas.Click += new System.EventHandler(this.btnVencidas_Click);
            // 
            // btnVerTodas
            // 
            this.btnVerTodas.BackColor = System.Drawing.Color.Cyan;
            this.btnVerTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodas.Location = new System.Drawing.Point(229, 425);
            this.btnVerTodas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Size = new System.Drawing.Size(147, 28);
            this.btnVerTodas.TabIndex = 8;
            this.btnVerTodas.Text = "VER TODAS";
            this.btnVerTodas.UseVisualStyleBackColor = false;
            this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(460, 44);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(573, 470);
            this.dgvFacturas.TabIndex = 9;
            this.dgvFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "CLIENTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "TIPO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "CONSUMO M³:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "TOTAL RD$:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "PANEL DE FACTURACION";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnVerTodas);
            this.Controls.Add(this.btnVencidas);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVencidas;
        private System.Windows.Forms.Button btnVerTodas;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
namespace AguaPotable.Presentacion
{
    partial class frmMedidores
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
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSuspender = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvMedidores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(173, 129);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(250, 22);
            this.txtSerial.TabIndex = 0;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(158, 203);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(255, 24);
            this.cmbCliente.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(46, 336);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 39);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSuspender
            // 
            this.btnSuspender.BackColor = System.Drawing.Color.IndianRed;
            this.btnSuspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuspender.Location = new System.Drawing.Point(237, 336);
            this.btnSuspender.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuspender.Name = "btnSuspender";
            this.btnSuspender.Size = new System.Drawing.Size(154, 39);
            this.btnSuspender.TabIndex = 3;
            this.btnSuspender.Text = "SUSPENDER";
            this.btnSuspender.UseVisualStyleBackColor = false;
            this.btnSuspender.Click += new System.EventHandler(this.btnSuspender_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.Green;
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Location = new System.Drawing.Point(46, 403);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(162, 39);
            this.btnActivar.TabIndex = 4;
            this.btnActivar.Text = "ACTIVAR";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(237, 403);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(154, 39);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvMedidores
            // 
            this.dgvMedidores.AllowUserToAddRows = false;
            this.dgvMedidores.AllowUserToDeleteRows = false;
            this.dgvMedidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedidores.Location = new System.Drawing.Point(487, 42);
            this.dgvMedidores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMedidores.MultiSelect = false;
            this.dgvMedidores.Name = "dgvMedidores";
            this.dgvMedidores.ReadOnly = true;
            this.dgvMedidores.RowHeadersWidth = 51;
            this.dgvMedidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedidores.Size = new System.Drawing.Size(543, 480);
            this.dgvMedidores.TabIndex = 6;
            this.dgvMedidores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedidores_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "N° de serie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "GESTION DE MEDIDORES";
            // 
            // frmMedidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedidores);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnSuspender);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtSerial);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMedidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMedidores";
            this.Load += new System.EventHandler(this.frmMedidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSuspender;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvMedidores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
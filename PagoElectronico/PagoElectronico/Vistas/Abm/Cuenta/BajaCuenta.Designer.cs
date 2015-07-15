namespace PagoElectronico.Vistas.Abm.Cuenta
{
    partial class BajaCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaCuenta));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Cuentas = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Doc:";
            // 
            // cbxTipoDoc
            // 
            this.cbxTipoDoc.FormattingEnabled = true;
            this.cbxTipoDoc.Location = new System.Drawing.Point(72, 9);
            this.cbxTipoDoc.Name = "cbxTipoDoc";
            this.cbxTipoDoc.Size = new System.Drawing.Size(62, 21);
            this.cbxTipoDoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Doc:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(222, 9);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(328, 8);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(39, 209);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Cuentas
            // 
            this.Cuentas.AllowUserToAddRows = false;
            this.Cuentas.AllowUserToDeleteRows = false;
            this.Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.tipoCuenta,
            this.saldo,
            this.editar,
            this.eliminar});
            this.Cuentas.Location = new System.Drawing.Point(15, 37);
            this.Cuentas.Name = "Cuentas";
            this.Cuentas.Size = new System.Drawing.Size(535, 150);
            this.Cuentas.TabIndex = 7;
            this.Cuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cuentas_CellContentClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            // 
            // tipoCuenta
            // 
            this.tipoCuenta.HeaderText = "Tipo Cuenta";
            this.tipoCuenta.Name = "tipoCuenta";
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Name = "editar";
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Name = "eliminar";
            // 
            // BajaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 262);
            this.Controls.Add(this.Cuentas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoDoc);
            this.Controls.Add(this.label1);
            this.Name = "BajaCuenta";
            this.Text = "BajaCuenta";
            this.Load += new System.EventHandler(this.BajaCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView Cuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}
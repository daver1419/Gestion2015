namespace PagoElectronico.PanelCliente
{
    partial class PanelCliente
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
            this.tabCamb = new System.Windows.Forms.TabPage();
            this.tabDeposito = new System.Windows.Forms.TabPage();
            this.tabRetiro = new System.Windows.Forms.TabPage();
            this.tabTransferencia = new System.Windows.Forms.TabPage();
            this.tabFacturacion = new System.Windows.Forms.TabPage();
            this.tabConsultaSaldo = new System.Windows.Forms.TabPage();
            this.tabPanelCliente = new System.Windows.Forms.TabControl();
            this.tabConfUsuario = new System.Windows.Forms.TabPage();
            this.tabPanelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCamb
            // 
            this.tabCamb.Location = new System.Drawing.Point(4, 22);
            this.tabCamb.Name = "tabCamb";
            this.tabCamb.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamb.Size = new System.Drawing.Size(549, 169);
            this.tabCamb.TabIndex = 6;
            this.tabCamb.Text = "Configuración Cuenta";
            this.tabCamb.UseVisualStyleBackColor = true;
            // 
            // tabDeposito
            // 
            this.tabDeposito.AllowDrop = true;
            this.tabDeposito.Location = new System.Drawing.Point(4, 22);
            this.tabDeposito.Name = "tabDeposito";
            this.tabDeposito.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposito.Size = new System.Drawing.Size(549, 169);
            this.tabDeposito.TabIndex = 4;
            this.tabDeposito.Text = "Deposito";
            this.tabDeposito.UseVisualStyleBackColor = true;
            // 
            // tabRetiro
            // 
            this.tabRetiro.Location = new System.Drawing.Point(4, 22);
            this.tabRetiro.Name = "tabRetiro";
            this.tabRetiro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetiro.Size = new System.Drawing.Size(549, 169);
            this.tabRetiro.TabIndex = 3;
            this.tabRetiro.Text = "Retiro";
            this.tabRetiro.UseVisualStyleBackColor = true;
            // 
            // tabTransferencia
            // 
            this.tabTransferencia.Location = new System.Drawing.Point(4, 22);
            this.tabTransferencia.Name = "tabTransferencia";
            this.tabTransferencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransferencia.Size = new System.Drawing.Size(549, 169);
            this.tabTransferencia.TabIndex = 2;
            this.tabTransferencia.Text = "Transferencia";
            this.tabTransferencia.UseVisualStyleBackColor = true;
            // 
            // tabFacturacion
            // 
            this.tabFacturacion.Location = new System.Drawing.Point(4, 22);
            this.tabFacturacion.Name = "tabFacturacion";
            this.tabFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacturacion.Size = new System.Drawing.Size(549, 169);
            this.tabFacturacion.TabIndex = 1;
            this.tabFacturacion.Text = "Facturacion";
            this.tabFacturacion.UseVisualStyleBackColor = true;
            // 
            // tabConsultaSaldo
            // 
            this.tabConsultaSaldo.Location = new System.Drawing.Point(4, 22);
            this.tabConsultaSaldo.Name = "tabConsultaSaldo";
            this.tabConsultaSaldo.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaSaldo.Size = new System.Drawing.Size(549, 169);
            this.tabConsultaSaldo.TabIndex = 0;
            this.tabConsultaSaldo.Text = "ConsultaSaldo";
            this.tabConsultaSaldo.UseVisualStyleBackColor = true;
            // 
            // tabPanelCliente
            // 
            this.tabPanelCliente.Controls.Add(this.tabConsultaSaldo);
            this.tabPanelCliente.Controls.Add(this.tabFacturacion);
            this.tabPanelCliente.Controls.Add(this.tabTransferencia);
            this.tabPanelCliente.Controls.Add(this.tabRetiro);
            this.tabPanelCliente.Controls.Add(this.tabDeposito);
            this.tabPanelCliente.Controls.Add(this.tabCamb);
            this.tabPanelCliente.Controls.Add(this.tabConfUsuario);
            this.tabPanelCliente.Location = new System.Drawing.Point(12, 26);
            this.tabPanelCliente.Name = "tabPanelCliente";
            this.tabPanelCliente.SelectedIndex = 0;
            this.tabPanelCliente.Size = new System.Drawing.Size(557, 195);
            this.tabPanelCliente.TabIndex = 0;
            // 
            // tabConfUsuario
            // 
            this.tabConfUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabConfUsuario.Name = "tabConfUsuario";
            this.tabConfUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfUsuario.Size = new System.Drawing.Size(549, 169);
            this.tabConfUsuario.TabIndex = 7;
            this.tabConfUsuario.Text = "Config. de Usuario";
            this.tabConfUsuario.UseVisualStyleBackColor = true;
            // 
            // PanelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 262);
            this.Controls.Add(this.tabPanelCliente);
            this.Name = "PanelCliente";
            this.Text = "PanelCliente";
            this.tabPanelCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCamb;
        private System.Windows.Forms.TabPage tabDeposito;
        private System.Windows.Forms.TabPage tabRetiro;
        private System.Windows.Forms.TabPage tabTransferencia;
        private System.Windows.Forms.TabPage tabFacturacion;
        private System.Windows.Forms.TabPage tabConsultaSaldo;
        private System.Windows.Forms.TabControl tabPanelCliente;
        private System.Windows.Forms.TabPage tabConfUsuario;


    }
}
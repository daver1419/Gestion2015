namespace PagoElectronico.Panel
{
    partial class PanelAdmin
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
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabRol = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.Cuenta = new System.Windows.Forms.TabPage();
            this.tabCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabRol);
            this.tabCliente.Controls.Add(this.tabPage2);
            this.tabCliente.Controls.Add(this.tabUsuario);
            this.tabCliente.Controls.Add(this.Cuenta);
            this.tabCliente.Location = new System.Drawing.Point(21, 39);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(604, 201);
            this.tabCliente.TabIndex = 0;
            // 
            // tabRol
            // 
            this.tabRol.Location = new System.Drawing.Point(4, 22);
            this.tabRol.Name = "tabRol";
            this.tabRol.Padding = new System.Windows.Forms.Padding(3);
            this.tabRol.Size = new System.Drawing.Size(596, 175);
            this.tabRol.TabIndex = 0;
            this.tabRol.Text = "Rol";
            this.tabRol.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(596, 175);
            this.tabUsuario.TabIndex = 2;
            this.tabUsuario.Text = "Usuario";
            this.tabUsuario.UseVisualStyleBackColor = true;
            // 
            // Cuenta
            // 
            this.Cuenta.Location = new System.Drawing.Point(4, 22);
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Padding = new System.Windows.Forms.Padding(3);
            this.Cuenta.Size = new System.Drawing.Size(596, 175);
            this.Cuenta.TabIndex = 3;
            this.Cuenta.Text = "Cuenta";
            this.Cuenta.UseVisualStyleBackColor = true;
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 278);
            this.Controls.Add(this.tabCliente);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.tabCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.TabPage tabRol;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.TabPage Cuenta;
    }
}
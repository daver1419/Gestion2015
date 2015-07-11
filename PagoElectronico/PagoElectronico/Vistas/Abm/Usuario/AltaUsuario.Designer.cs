namespace PagoElectronico.Vistas.Abm.Usuario
{
    partial class AltaUsuario
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
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.rolLabel = new System.Windows.Forms.Label();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.preguntaSecretaLabel = new System.Windows.Forms.Label();
            this.preguntaSecretaTextBox = new System.Windows.Forms.TextBox();
            this.respuestaSecretaLabel = new System.Windows.Forms.Label();
            this.respuestaSecretaTextBox = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(12, 23);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(55, 13);
            this.usuarioLabel.TabIndex = 1;
            this.usuarioLabel.Text = "Username";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(126, 20);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(137, 20);
            this.usuarioTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 49);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 13);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Contraseña";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(126, 46);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(137, 20);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Location = new System.Drawing.Point(12, 75);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(23, 13);
            this.rolLabel.TabIndex = 13;
            this.rolLabel.Text = "Rol";
            // 
            // rolComboBox
            // 
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Location = new System.Drawing.Point(126, 70);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(137, 21);
            this.rolComboBox.TabIndex = 14;
            this.rolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // preguntaSecretaLabel
            // 
            this.preguntaSecretaLabel.AutoSize = true;
            this.preguntaSecretaLabel.Location = new System.Drawing.Point(12, 100);
            this.preguntaSecretaLabel.Name = "preguntaSecretaLabel";
            this.preguntaSecretaLabel.Size = new System.Drawing.Size(90, 13);
            this.preguntaSecretaLabel.TabIndex = 15;
            this.preguntaSecretaLabel.Text = "Pregunta Secreta";
            // 
            // preguntaSecretaTextBox
            // 
            this.preguntaSecretaTextBox.Location = new System.Drawing.Point(126, 97);
            this.preguntaSecretaTextBox.Name = "preguntaSecretaTextBox";
            this.preguntaSecretaTextBox.Size = new System.Drawing.Size(137, 20);
            this.preguntaSecretaTextBox.TabIndex = 16;
            // 
            // respuestaSecretaLabel
            // 
            this.respuestaSecretaLabel.AutoSize = true;
            this.respuestaSecretaLabel.Location = new System.Drawing.Point(12, 126);
            this.respuestaSecretaLabel.Name = "respuestaSecretaLabel";
            this.respuestaSecretaLabel.Size = new System.Drawing.Size(98, 13);
            this.respuestaSecretaLabel.TabIndex = 17;
            this.respuestaSecretaLabel.Text = "Respuesta Secreta";        
            // 
            // respuestaSecretaTextBox
            // 
            this.respuestaSecretaTextBox.Location = new System.Drawing.Point(126, 123);
            this.respuestaSecretaTextBox.Name = "respuestaSecretaTextBox";
            this.respuestaSecretaTextBox.Size = new System.Drawing.Size(137, 20);
            this.respuestaSecretaTextBox.TabIndex = 18;
            this.respuestaSecretaTextBox.UseSystemPasswordChar = true;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(290, 161);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 19;
            this.guardarButton.Text = "Guardar ";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(13, 160);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 20;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 199);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.respuestaSecretaTextBox);
            this.Controls.Add(this.respuestaSecretaLabel);
            this.Controls.Add(this.preguntaSecretaTextBox);
            this.Controls.Add(this.preguntaSecretaLabel);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(this.rolLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.usuarioLabel);
            this.Name = "AltaUsuario";
            this.Text = "Alta de Usuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.Label preguntaSecretaLabel;
        private System.Windows.Forms.TextBox preguntaSecretaTextBox;
        private System.Windows.Forms.Label respuestaSecretaLabel;
        private System.Windows.Forms.TextBox respuestaSecretaTextBox;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button limpiarButton;
    }
}
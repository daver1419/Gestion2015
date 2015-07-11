namespace PagoElectronico.Vistas.Abm.Rol
{
    partial class AltaRol
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
            this.nombreRolLabel = new System.Windows.Forms.Label();
            this.nombreRolTextBox = new System.Windows.Forms.TextBox();
            this.funcionalidadesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.funcionalidadesLabel = new System.Windows.Forms.Label();
            this.guardarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nombreRolLabel
            // 
            this.nombreRolLabel.AutoSize = true;
            this.nombreRolLabel.Location = new System.Drawing.Point(9, 19);
            this.nombreRolLabel.Name = "nombreRolLabel";
            this.nombreRolLabel.Size = new System.Drawing.Size(78, 13);
            this.nombreRolLabel.TabIndex = 0;
            this.nombreRolLabel.Text = "Nombre de Rol";
            // 
            // nombreRolTextBox
            // 
            this.nombreRolTextBox.Location = new System.Drawing.Point(97, 16);
            this.nombreRolTextBox.Name = "nombreRolTextBox";
            this.nombreRolTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreRolTextBox.TabIndex = 2;
            // 
            // funcionalidadesCheckedListBox
            // 
            this.funcionalidadesCheckedListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.funcionalidadesCheckedListBox.FormattingEnabled = true;
            this.funcionalidadesCheckedListBox.Location = new System.Drawing.Point(12, 68);
            this.funcionalidadesCheckedListBox.Name = "funcionalidadesCheckedListBox";
            this.funcionalidadesCheckedListBox.Size = new System.Drawing.Size(185, 94);
            this.funcionalidadesCheckedListBox.TabIndex = 1;
            // 
            // funcionalidadesLabel
            // 
            this.funcionalidadesLabel.AutoSize = true;
            this.funcionalidadesLabel.Location = new System.Drawing.Point(9, 49);
            this.funcionalidadesLabel.Name = "funcionalidadesLabel";
            this.funcionalidadesLabel.Size = new System.Drawing.Size(84, 13);
            this.funcionalidadesLabel.TabIndex = 5;
            this.funcionalidadesLabel.Text = "Funcionalidades";
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(144, 231);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 6;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(12, 231);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 7;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(12, 178);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoComboBox.TabIndex = 8;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 266);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.funcionalidadesLabel);
            this.Controls.Add(this.funcionalidadesCheckedListBox);
            this.Controls.Add(this.nombreRolTextBox);
            this.Controls.Add(this.nombreRolLabel);
            this.Name = "AltaRol";
            this.Text = "Alta de Rol";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreRolLabel;
        private System.Windows.Forms.TextBox nombreRolTextBox;
        private System.Windows.Forms.CheckedListBox funcionalidadesCheckedListBox;
        private System.Windows.Forms.Label funcionalidadesLabel;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.ComboBox estadoComboBox;
    }
}
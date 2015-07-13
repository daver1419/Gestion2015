namespace PagoElectronico.Vistas.Abm.Rol
{
    partial class ModificarRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.funcionalidadesLabel = new System.Windows.Forms.Label();
            this.funcionalidadesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.nombreRolTextBox = new System.Windows.Forms.TextBox();
            this.nombreRolLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Estado";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(97, 171);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(100, 21);
            this.estadoComboBox.TabIndex = 16;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(12, 225);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 15;
            this.limpiarButton.Text = "Cancelar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(122, 225);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 14;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            // 
            // funcionalidadesLabel
            // 
            this.funcionalidadesLabel.AutoSize = true;
            this.funcionalidadesLabel.Location = new System.Drawing.Point(9, 43);
            this.funcionalidadesLabel.Name = "funcionalidadesLabel";
            this.funcionalidadesLabel.Size = new System.Drawing.Size(84, 13);
            this.funcionalidadesLabel.TabIndex = 13;
            this.funcionalidadesLabel.Text = "Funcionalidades";
            // 
            // funcionalidadesCheckedListBox
            // 
            this.funcionalidadesCheckedListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.funcionalidadesCheckedListBox.FormattingEnabled = true;
            this.funcionalidadesCheckedListBox.Location = new System.Drawing.Point(12, 62);
            this.funcionalidadesCheckedListBox.Name = "funcionalidadesCheckedListBox";
            this.funcionalidadesCheckedListBox.Size = new System.Drawing.Size(185, 94);
            this.funcionalidadesCheckedListBox.TabIndex = 11;
            // 
            // nombreRolTextBox
            // 
            this.nombreRolTextBox.Location = new System.Drawing.Point(97, 10);
            this.nombreRolTextBox.Name = "nombreRolTextBox";
            this.nombreRolTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreRolTextBox.TabIndex = 12;
            // 
            // nombreRolLabel
            // 
            this.nombreRolLabel.AutoSize = true;
            this.nombreRolLabel.Location = new System.Drawing.Point(9, 13);
            this.nombreRolLabel.Name = "nombreRolLabel";
            this.nombreRolLabel.Size = new System.Drawing.Size(78, 13);
            this.nombreRolLabel.TabIndex = 10;
            this.nombreRolLabel.Text = "Nombre de Rol";
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.funcionalidadesLabel);
            this.Controls.Add(this.funcionalidadesCheckedListBox);
            this.Controls.Add(this.nombreRolTextBox);
            this.Controls.Add(this.nombreRolLabel);
            this.Name = "ModificarRol";
            this.Text = "Modificar Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Label funcionalidadesLabel;
        private System.Windows.Forms.CheckedListBox funcionalidadesCheckedListBox;
        private System.Windows.Forms.TextBox nombreRolTextBox;
        private System.Windows.Forms.Label nombreRolLabel;

    }
}
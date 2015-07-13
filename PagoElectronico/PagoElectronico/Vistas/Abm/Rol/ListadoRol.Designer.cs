namespace PagoElectronico.Vistas.Abm.Rol
{
    partial class ListadoRol
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
            this.rolDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buscarButton = new System.Windows.Forms.Button();
            this.rolLabel = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.funcionaliadadLabel = new System.Windows.Forms.Label();
            this.funcComboBox = new System.Windows.Forms.ComboBox();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.rolTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rolDataGridView
            // 
            this.rolDataGridView.AllowUserToDeleteRows = false;
            this.rolDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rolDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.rolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Rol,
            this.Estado,
            this.Seleccionar,
            this.Eliminar});
            this.rolDataGridView.Location = new System.Drawing.Point(12, 205);
            this.rolDataGridView.Name = "rolDataGridView";
            this.rolDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolDataGridView.Size = new System.Drawing.Size(356, 162);
            this.rolDataGridView.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 48;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Visible = false;
            this.Seleccionar.Width = 69;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = false;
            this.Eliminar.Width = 49;
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarButton.Location = new System.Drawing.Point(293, 160);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Location = new System.Drawing.Point(15, 55);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(23, 13);
            this.rolLabel.TabIndex = 3;
            this.rolLabel.Text = "Rol";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(12, 160);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 4;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(this.codigoLabel);
            this.groupBox1.Controls.Add(this.funcionaliadadLabel);
            this.groupBox1.Controls.Add(this.funcComboBox);
            this.groupBox1.Controls.Add(this.estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(this.rolTextBox);
            this.groupBox1.Controls.Add(this.rolLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busqueda";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(94, 27);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(120, 20);
            this.codigoTextBox.TabIndex = 10;
            this.codigoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoTextBox_KeyPress);
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(15, 30);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 9;
            this.codigoLabel.Text = "Codigo";
            // 
            // funcionaliadadLabel
            // 
            this.funcionaliadadLabel.AutoSize = true;
            this.funcionaliadadLabel.Location = new System.Drawing.Point(15, 106);
            this.funcionaliadadLabel.Name = "funcionaliadadLabel";
            this.funcionaliadadLabel.Size = new System.Drawing.Size(73, 13);
            this.funcionaliadadLabel.TabIndex = 8;
            this.funcionaliadadLabel.Text = "Funcionalidad";
            // 
            // funcComboBox
            // 
            this.funcComboBox.FormattingEnabled = true;
            this.funcComboBox.Location = new System.Drawing.Point(94, 103);
            this.funcComboBox.Name = "funcComboBox";
            this.funcComboBox.Size = new System.Drawing.Size(121, 21);
            this.funcComboBox.TabIndex = 7;
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(15, 79);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(40, 13);
            this.estadoLabel.TabIndex = 6;
            this.estadoLabel.Text = "Estado";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(94, 76);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoComboBox.TabIndex = 5;
            // 
            // rolTextBox
            // 
            this.rolTextBox.Location = new System.Drawing.Point(94, 52);
            this.rolTextBox.Name = "rolTextBox";
            this.rolTextBox.Size = new System.Drawing.Size(121, 20);
            this.rolTextBox.TabIndex = 4;
            // 
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.rolDataGridView);
            this.Name = "ListadoRol";
            this.Text = "Listado de Roles";
            this.Load += new System.EventHandler(this.ListadoRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rolDataGridView;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rolTextBox;
        private System.Windows.Forms.Label funcionaliadadLabel;
        private System.Windows.Forms.ComboBox funcComboBox;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label codigoLabel;
    }
}
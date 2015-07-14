namespace PagoElectronico.Vistas.Abm.Cuenta
{
    partial class AltaCuenta
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
            this.txtNDoc = new System.Windows.Forms.TextBox();
            this.cbxTD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxP = new System.Windows.Forms.ComboBox();
            this.cbxM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEx = new System.Windows.Forms.ComboBox();
            this.cbxCant = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TipoDoc\r\n";
            // 
            // txtNDoc
            // 
            this.txtNDoc.Location = new System.Drawing.Point(265, 29);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNDoc.TabIndex = 1;
            this.txtNDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNDoc_KeyPress);
            // 
            // cbxTD
            // 
            this.cbxTD.FormattingEnabled = true;
            this.cbxTD.Location = new System.Drawing.Point(68, 28);
            this.cbxTD.Name = "cbxTD";
            this.cbxTD.Size = new System.Drawing.Size(79, 21);
            this.cbxTD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número Doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Cuenta";
            // 
            // cbxTC
            // 
            this.cbxTC.FormattingEnabled = true;
            this.cbxTC.Location = new System.Drawing.Point(105, 64);
            this.cbxTC.Name = "cbxTC";
            this.cbxTC.Size = new System.Drawing.Size(121, 21);
            this.cbxTC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Moneda";
            // 
            // cbxP
            // 
            this.cbxP.FormattingEnabled = true;
            this.cbxP.Location = new System.Drawing.Point(105, 96);
            this.cbxP.Name = "cbxP";
            this.cbxP.Size = new System.Drawing.Size(121, 21);
            this.cbxP.TabIndex = 8;
            // 
            // cbxM
            // 
            this.cbxM.FormattingEnabled = true;
            this.cbxM.Location = new System.Drawing.Point(105, 125);
            this.cbxM.Name = "cbxM";
            this.cbxM.Size = new System.Drawing.Size(121, 21);
            this.cbxM.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "¿Quiere extender su periodo?";
            // 
            // cbxEx
            // 
            this.cbxEx.FormattingEnabled = true;
            this.cbxEx.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbxEx.Location = new System.Drawing.Point(182, 162);
            this.cbxEx.Name = "cbxEx";
            this.cbxEx.Size = new System.Drawing.Size(121, 21);
            this.cbxEx.TabIndex = 12;
            // 
            // cbxCant
            // 
            this.cbxCant.FormattingEnabled = true;
            this.cbxCant.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxCant.Location = new System.Drawing.Point(182, 189);
            this.cbxCant.Name = "cbxCant";
            this.cbxCant.Size = new System.Drawing.Size(64, 21);
            this.cbxCant.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "¿Cuantas Veces?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AltaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxCant);
            this.Controls.Add(this.cbxEx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxM);
            this.Controls.Add(this.cbxP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTD);
            this.Controls.Add(this.txtNDoc);
            this.Controls.Add(this.label1);
            this.Name = "AltaCuenta";
            this.Text = "AltaCuenta";
            this.Load += new System.EventHandler(this.AltaCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNDoc;
        private System.Windows.Forms.ComboBox cbxTD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxP;
        private System.Windows.Forms.ComboBox cbxM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEx;
        private System.Windows.Forms.ComboBox cbxCant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
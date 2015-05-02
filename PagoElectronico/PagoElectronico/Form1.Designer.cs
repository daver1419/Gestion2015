namespace PagoElectronico
{
    using System.Data.SqlClient;

    partial class Form1
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

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            SqlConnection sqlConnection = new SqlConnection("Server=localhost\\SQLSERVER2008; Database=GD1C2015; User ID=gd; Password=gd2015;");

            SqlDataReader reader;
            SqlCommand sqlCommand = new SqlCommand("SELECT top 10 * FROM [gd_esquema].[Maestra] ms where ms.Cuenta_Numero = 1111111111111144", sqlConnection);
            sqlConnection.Open();


            reader = sqlCommand.ExecuteReader();
            

            while (reader.Read())
            {
                System.Console.Write("contains data "+ reader["Transf_Fecha"].ToString() + "\n");
            }

            sqlConnection.Close();


        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
        }

        #endregion
    }
}


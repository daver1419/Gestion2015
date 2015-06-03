using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PagoElectronico.Panel
{
    public partial class PanelAdmin : Form
    {
       public PagoElectronico.Entidad.Usuario usuario;

        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void btnAltaClienteUsu_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabCliente;
            panelBusquedaUsu.Visible = false;

        }

        private void btnAddTarjeta_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabTarjeta;
            // llenar los label para cliente y  numero de cuenta 

            lblNcuentaTar.Text = txtNumeroCuenta.Text;
           


        }

        private void btnConfTarj_Click(object sender, EventArgs e)
        {
            btnAddTarjeta.Visible = true;
        }

     
      

        
       
      

      

     

      

        

       

     

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Entidad;
using PagoElectronico.PanelCliente;

namespace PagoElectronico.Login
{
    public partial class Login : Form
    {
        Boolean posibleCliente;
        Usuario usu;
        PagoElectronico.ABM_de_Usuario.ControladorUsuario controladorUsuario = new PagoElectronico.ABM_de_Usuario.ControladorUsuario();
        public Login()
        {
            InitializeComponent();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnIngresar.Visible = false;
            btnRegistrar.Visible = false;

            posibleCliente = true;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(textUsuario.Text == null && textContra.Text == null){
                MessageBox.Show("Debera ingresar un usuario y contraseña");
                
            }else{

            controladorUsuario.crearClientePosible(textUsuario.Text , textContra.Text, posibleCliente); 
            } 
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(textUsuario.Text == null && textContra.Text == null){
                MessageBox.Show("Debera ingresar un usuario y contraseña");
                
            }

            this.usu = controladorUsuario.buscarUsuario(textUsuario.Text, textContra.Text);

            if (usu != null)
            {
                //inicio panel de aplicaciones segun el rol si es administrador por default tamb es cliente
                if (usu.getRol() == "administrador"){ 
                  
                    
                    btnRegistrar.Visible=false;
                    btnIngresar.Visible=false;
                   
                    lblContrasena.Visible=false;
                    textContra.Visible=false;

                    textUsuario.ReadOnly=true;

                    lblrol.Visible=true;
                    btnCliente.Visible=true;
                    btnAdministrador.Visible =true;

                    
                               

                }else if (usu.getRol()=="cliente"){

                    this.Close();
                    
                    PagoElectronico.PanelCliente.PanelCliente panelCliente = new PagoElectronico.PanelCliente.PanelCliente();
                    panelCliente.usuario = usu;

                }

            }else {
                   MessageBox.Show("No se encontro el  usuario " + textUsuario.Text );
            }


        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Close();

            PagoElectronico.PanelCliente.PanelCliente panelCliente = new PagoElectronico.PanelCliente.PanelCliente();
            panelCliente.usuario = usu;

        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            this.Close();
            PagoElectronico.Panel.PanelAdmin panelAdm = new PagoElectronico.Panel.PanelAdmin();

            panelAdm.usuario = usu; 
        }

      







      
    }
}

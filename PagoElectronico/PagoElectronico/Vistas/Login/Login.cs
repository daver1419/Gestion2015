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
using PagoElectronico.Panel;
using PagoElectronico.Controladores;

namespace PagoElectronico.Login
{
    public partial class Login : Form
    {
        
        Usuario usu;
        ControladorAdmin controladorUsuario = new ControladorAdmin();
        public Login()
        {
            InitializeComponent();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "";
            textContra.Text = "";
            lblContrasena.Text = "Apellido:";
            lblUsuario.Text = "Nombre:";
            textContra.UseSystemPasswordChar = false;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnIngresar.Visible = false;
            btnRegistrar.Visible = false;

           


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text.Trim().CompareTo("") == 0 || textContra.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Debe ingresar Usuario y Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } else{

                String username = textUsuario.Text + "." + textContra.Text;
                String password = Utilitario.Util.GetSHA256Encriptado(username);
                controladorUsuario.crearClientePosible(username,password); 
            } 
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text.Trim().CompareTo("") == 0 || textContra.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Debera ingresar un usuario y contraseña");

            }

            List<Usuario> listaU = new List<Usuario>();
            listaU = controladorUsuario.login(textUsuario.Text, textContra.Text);

            if (listaU.Count()== 0)
            {  
                MessageBox.Show("No se encontro Resultado para el usuario y contraseña ingresado ");
            }
            else if (listaU.First().habilitado )
            {           
                if (listaU.Count() == 2)
                {
                    usu = listaU.First();
                    lblrol.Visible = true;
                    btnCliente.Visible = true;
                    btnAdministrador.Visible = true;
                    btnRegistrar.Visible = false;
                    btnIngresar.Visible = false;
                }
                else
                {
                    usu = listaU.First();
                    
                    if (listaU.First().rol == 1)
                    {
                        lanzarAdminForm();                        
                    }
                    else if (listaU.First().rol == 2)
                    {
                        lanzarClienteForm();
                    }
                    
                }


            }else
            {
                  MessageBox.Show("El usuario se encuentra bloqueado");
               
            }
        }

        public void lanzarForm()
        {
            
            
        }

        public void lanzarAdminForm()
        {
            System.Threading.Thread t = new System.Threading.Thread(
                            new System.Threading.ThreadStart(adminForm));
            t.Start();
            this.Close();
        }

        public void adminForm()
        {         
            PanelAdmin panelAdmin = new PagoElectronico.Panel.PanelAdmin();
            panelAdmin.usuarioLogeado = usu;
            Application.Run(panelAdmin);
        }

        public void lanzarClienteForm()
        {
            System.Threading.Thread t = new System.Threading.Thread(
                            new System.Threading.ThreadStart(clienteForm));
            t.Start();
            this.Close();         
        }

        public void clienteForm()
        {
            PanelCliente.PanelCliente panelCliente = new PanelCliente.PanelCliente();
            panelCliente.usuarioLogeado = usu;
            Application.Run(panelCliente);
        }


        private void btnCliente_Click(object sender, EventArgs e)
        {
           usu.rol = 2;
           lanzarClienteForm();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            usu.rol = 1;
            lanzarAdminForm();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "";
            textContra.Text = "";
            lblUsuario.Text = "Usuario:";
            lblContrasena.Text = "Contraseña";
            textContra.UseSystemPasswordChar = true;

            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            lblrol.Visible = false;
            btnCliente.Visible = false;
            btnAdministrador.Visible = false;
            btnIngresar.Visible = true;
            btnRegistrar.Visible = true;

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

      
       

      







      
    }
}

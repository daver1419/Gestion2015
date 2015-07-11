using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.DAO;
using PagoElectronico.Entidad;

namespace PagoElectronico.Vistas.Abm.Usuario
{
    public interface UsuarioListener
    {
        void onCreateUserFinished(int code, String msg);
        void onCreateUserError(int code, String msg);
    }

    public partial class AltaUsuario : Form , UsuarioListener
    {
        private Controladores.ControladorAdmin controladorAdmin = new PagoElectronico.Controladores.ControladorAdmin();

        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void loadCombo()
        {   
            // panel usuario
            List<Rol> dt = controladorAdmin.getRoles();
            rolComboBox.DataSource = dt;
            rolComboBox.DisplayMember = "DESCRIPCION";
            rolComboBox.Text = "Elegir una";
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
           controladorAdmin.crearUsuario(usuarioTextBox.Text, 
                                        passwordTextBox.Text,
                                        preguntaSecretaTextBox.Text,
                                        respuestaSecretaTextBox.Text,
                                        (int)((Rol)rolComboBox.SelectedValue).id, this);
        }

        public void onCreateUserFinished(int code, String msg)
        {
            if (code == 1)
            {   //Usuario creado
                MessageBox.Show(msg + usuarioTextBox.Text);
                this.Close();
            }
            else
            {   
                MessageBox.Show(msg);
            }
           
        }

        public void onCreateUserError(int code, String msg)
        {
            MessageBox.Show(msg);
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            usuarioTextBox.Text = "";
            passwordTextBox.Text = "";
            rolComboBox.ResetText();
            preguntaSecretaTextBox.Text = "";
            respuestaSecretaTextBox.Text = "";
            
        }
        
    }
}

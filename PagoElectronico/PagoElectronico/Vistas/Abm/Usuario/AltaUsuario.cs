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
    public partial class AltaUsuario : Form
    {
        private RolDAO rolDAO;
        private Controladores.ControladorAdmin controladorAdmin;

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
            rolDAO = new RolDAO();
            
            // panel usuario
            List<Rol> dt = rolDAO.listaRol();
            rolComboBox.DataSource = dt;
            rolComboBox.DisplayMember = "DESCRIPCION";
            rolComboBox.Text = "Elegir una";

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {

            PagoElectronico.Entidad.Usuario usuario = new PagoElectronico.Entidad.Usuario(usuarioTextBox.Text, passwordTextBox.Text,
                                               preguntaSecretaTextBox.Text, respuestaSecretaTextBox.Text, 
                                               (int)rolComboBox.SelectedItem, false, null);
            controladorAdmin.crearUsuario(usuario);
        }

        
    }
}

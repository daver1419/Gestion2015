using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Entidad;

namespace PagoElectronico.Vistas.Abm.Rol
{
    public partial class ListadoRol : Form
    {
        private String action { get; set; }
        private Controladores.ControladorRol controladorRol = new Controladores.ControladorRol();

        public ListadoRol(String fromAction)
        {
            action = fromAction;
            InitializeComponent();
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {
            if(action.Equals("Modificar")){
                Seleccionar.Visible = true;              
            }else if(action.Equals("Eliminar")){
                Eliminar.Visible = true;              
            }

            List<Funcionalidad> funcionalidades = controladorRol.getFuncionalidades();
            funcComboBox.DataSource = funcionalidades;
            funcComboBox.ResetText();
            funcComboBox.SelectedIndex = -1;

            estadoComboBox.Items.Add(new Estado("Activo"));
            estadoComboBox.Items.Add(new Estado("Inactivo"));

            rolDataGridView.DataSource = null;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {

            rolDataGridView.Rows.Clear();

            List<PagoElectronico.Entidad.Rol> roles = controladorRol.getRoles(
                codigoTextBox.Text.Equals("") ? -1:Convert.ToInt32(codigoTextBox.Text), rolTextBox.Text,
                (Funcionalidad) funcComboBox.SelectedItem, (Estado)estadoComboBox.SelectedItem);


            foreach (PagoElectronico.Entidad.Rol rol in roles)
            {
                rolDataGridView.Rows.Add(rol.id, rol.descripcion, rol.estado ? "Activo": "Inactivo");
            }
  
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        public void limpiarDatos()
        {
            codigoTextBox.Text = "";
            rolTextBox.Text = "";
            funcComboBox.ResetText();
            funcComboBox.SelectedItem = -1;
            funcComboBox.SelectedText = "";
            estadoComboBox.ResetText();
            estadoComboBox.SelectedItem = -1;
            estadoComboBox.SelectedText = "";
            rolDataGridView.Rows.Clear();
        }

        public void codigoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}

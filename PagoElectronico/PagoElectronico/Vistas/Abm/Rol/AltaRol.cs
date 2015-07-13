using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Controladores;
using PagoElectronico.Entidad;

namespace PagoElectronico.Vistas.Abm.Rol
{
    
    public partial class AltaRol : Form, PagoElectronico.Controladores.Controlador.Listener
    {

       ControladorRol controladorRol = new ControladorRol();

        public AltaRol()
        {
            InitializeComponent();
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {   
            List<PagoElectronico.Entidad.Funcionalidad> funcionalidades = controladorRol.getFuncionalidades();
            funcionalidadesCheckedListBox.DataSource = funcionalidades;

            estadoComboBox.Items.Add(new Estado("Activo"));
            estadoComboBox.Items.Add(new Estado("Inactivo"));
            estadoComboBox.SelectedIndex = 0;
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            
            List<Funcionalidad> list = new List<Funcionalidad>();
            for (int i = 0; i < funcionalidadesCheckedListBox.Items.Count; i++)
            {
                if (funcionalidadesCheckedListBox.GetItemChecked(i))
                {
                    list.Add((Funcionalidad)funcionalidadesCheckedListBox.Items[i]);
                  
                }
            }

            if (nombreRolTextBox.Text.Equals(""))
            {
                if (list.Count == 0)
                {
                    MessageBox.Show("El rol no puede ser vacio y debe seleccionar al menos una funcionaidad.");
                }
                else
                {
                    MessageBox.Show("El rol no puede ser vacio");
                }

                return;
            }
            else if (list.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una funcionaidad.");
                return;    
            }

            controladorRol.crearRol(nombreRolTextBox.Text, list, (Estado)estadoComboBox.SelectedItem, this);
        }

        public void onCreateFinished(int code, String msg)
        {
            if (code == 1)
            {   //Rol creado
                MessageBox.Show(msg + nombreRolTextBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        public void onCreateError(int code, String msg)
        {
            MessageBox.Show(msg);
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreRolTextBox.Text = "";
                	
            foreach(int i in funcionalidadesCheckedListBox.CheckedIndices)
            {
                funcionalidadesCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            estadoComboBox.SelectedIndex = 0;
        }


    }
}

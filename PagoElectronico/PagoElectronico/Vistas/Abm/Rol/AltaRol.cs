﻿using System;
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

            estadoComboBox.Items.Add("Activo");
            estadoComboBox.Items.Add("Inactivo");
            estadoComboBox.SelectedItem = 1;
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

            controladorRol.crearRol(nombreRolTextBox.Text, list, estadoComboBox.SelectedIndex + 1, this);
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


    }
}
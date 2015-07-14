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
using PagoElectronico.Properties;

namespace PagoElectronico.Vistas.Abm.Cuenta
{
    public partial class AltaCuenta : Form
    {

        ControladorSis controlSis = new ControladorSis();
        ControladorCuenta controlCuenta = new ControladorCuenta();

        List<TipoDoc> listaTD = new List<TipoDoc>();
        List<Pais> listaP = new List<Pais>();
        List<TipoCuenta> listaTC = new List<TipoCuenta>();
        List<TipoMoneda> listaTM = new List<TipoMoneda>();

        public AltaCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarCampos();

            TipoDoc tipoDoc = new TipoDoc();
            tipoDoc = (TipoDoc)cbxTD.SelectedItem;
            decimal numeroDoc = decimal.Parse(txtNDoc.Text);
            
            TipoCuenta tCuenta = new TipoCuenta();
            tCuenta = (TipoCuenta)cbxTC.SelectedItem;

            Pais pais = new Pais();
            pais = (Pais)cbxP.SelectedItem;

            TipoMoneda tmod = new TipoMoneda();
            tmod = (TipoMoneda)cbxM.SelectedItem;

            String extenderPeriodo = (String)cbxEx.SelectedItem;

            int periodo = 1;
            if (extenderPeriodo == "SI")
            {
                periodo = int.Parse(cbxCant.SelectedItem.ToString());
            }

            

            controlCuenta.altaCuenta(tipoDoc.id, numeroDoc, tCuenta.id,  pais.id, tmod.id, periodo);

        }


        private void validarCampos()
        {
            if (cbxTD.SelectedItem == null || txtNDoc.Text.Trim().CompareTo("") == 0 || cbxTC.SelectedItem == null
                || cbxP.SelectedItem ==  null || cbxM.SelectedItem == null || cbxEx.SelectedItem == null)
            {
                MessageBox.Show("Los campos obligatorio (*) ");

            }
           
        }
        private void AltaCuenta_Load(object sender, EventArgs e)
        {
            listaTD= controlSis.listaTipoDoc();

            cbxTD.DataSource = listaTD;
            cbxTD.DisplayMember = "DESCRIPCION";
            cbxTD.Text = "Eliga una opción";

            listaP = controlSis.listaPais();
            cbxP.DataSource = listaP;
            cbxP.DisplayMember = "DESCRIPCION";
            cbxP.Text = "Eliga una opción";
            
            listaTC = controlSis.listaTipoCuenta();

            cbxTC.DataSource = listaTC;
            cbxTC.DisplayMember = "DECRIPCION";
            cbxTC.Text = "Eliga una opción";

            listaTM = controlSis.listaTipoMoneda();
            cbxM.DataSource = listaTM;
            cbxM.DisplayMember = "DESCRIPCION";
            cbxM.Text = "Eliga una opción";



        }

        private void txtNDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtNDoc.Text.Length; i++)
            {
                if (txtNDoc.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNDoc.Text = "";
        }

       
    }
}

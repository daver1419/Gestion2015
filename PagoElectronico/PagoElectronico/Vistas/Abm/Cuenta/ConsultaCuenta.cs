using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Entidad;
using PagoElectronico.Controladores;


namespace PagoElectronico.Vistas.Abm.Cuenta
{
    public partial class ConsultaCuenta : Form
    {
        List<TipoDoc> listTD = new List<TipoDoc>();
        ControladorSis controlSis = new ControladorSis();
        ControladorCuenta controlCuenta = new ControladorCuenta();
        List<PagoElectronico.Entidad.Cuenta> listaCuenta = new List<PagoElectronico.Entidad.Cuenta>();
         
        public ConsultaCuenta()
        {
            InitializeComponent();
        }

       
        private void Consulta_Load(object sender, EventArgs e)
        {
            listTD = controlSis.listaTipoDoc();
            cbxCTD.DataSource = listTD;
            cbxCTD.DisplayMember = "DECRIPCION";
            cbxCTD.Text = "Eliga una opción";
       
        }

        private void txtND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtND.Text.Length; i++)
            {
                if (txtND.Text[i] == '.')
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            validarCampo();
             TipoDoc tdoc= new TipoDoc ();
             tdoc = (TipoDoc)cbxCTD.SelectedItem;
             decimal numDoc = decimal.Parse(txtND.Text);
           listaCuenta= controlCuenta.consultaCuentaCli(tdoc.id, numDoc);
           listBox1.DataSource = listaCuenta;
           listBox1.DisplayMember = "IDCUENTA";
        }

        private void  validarCampo(){

            if ( cbxCTD.SelectedItem == null  && txtND.Text.Trim().CompareTo("")== 0)
            {
                MessageBox.Show("Los campos Tipo Doc  y Número Doc son obligatorios");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtND.Text = "";
            
        }

    }
}

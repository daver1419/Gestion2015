using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoElectronico.Entidad;
using PagoElectronico.Controladores;
using PagoElectronico.Properties;

namespace PagoElectronico.Vistas.Abm.Cuenta
{
    public partial class ModificarCuenta : Form
    {

        ControladorSis controlSis = new ControladorSis();
        List<Pais> paises = new List<Pais>();
        Pais pais = new Pais();
        TipoCuenta tCuenta = new TipoCuenta();
        List<TipoCuenta> listaTipoCuenta = new List<TipoCuenta>();
        ControladorCuenta controlCuenta = new ControladorCuenta();

        PagoElectronico.Entidad.Cuenta cuentaMod = new PagoElectronico.Entidad.Cuenta();
        string paisSelec;
        string tipoCuentaSelect;

        public ModificarCuenta()
        {
            InitializeComponent();
        }



        public void iniciarPanel( decimal numero )
        {
             

            Conexion conn = new Conexion();
            SqlDataReader resultado = conn.consultar("select cuen_id , cuen_saldo , pais_desc , cuen_fecha_creacion , cuen_fecha_cierre , tipo_cuenta_desc , cuen_pais_id , cuen_tipo_cuenta_id  from THE_ULTIMATES.Cuenta join THE_ULTIMATES.Pais on cuen_pais_id = pais_id join  THE_ULTIMATES.Tipo_Cuenta on tipo_cuenta_id = cuen_tipo_cuenta_id where cuen_id = " + numero);
            while (resultado.Read())
            {
               
                 cuentaMod.idCuenta = resultado.GetDecimal(0);
                 cuentaMod.cuentaSaldo = resultado.GetDecimal(1);
                 paisSelec = resultado.GetString(2);
                 cuentaMod.fechaCreacion = resultado.GetDateTime(3);
             //    cuentaMod.FechaCierre = resultado.GetDateTime(4);
                 tipoCuentaSelect = resultado.GetString(5);
                 cuentaMod.idPais = resultado.GetDecimal(6);
                 cuentaMod.tipoCuenta = resultado.GetInt32(7);

                pais.id= cuentaMod.idPais;
                pais.descripcion= paisSelec;

                tCuenta.id = cuentaMod.tipoCuenta;
                tCuenta.descripcion = tipoCuentaSelect;
              

            }
            conn.desconectar();
            txtNum.Text = cuentaMod.idCuenta.ToString();
            txtSaldo.Text = cuentaMod.cuentaSaldo.ToString();

            paises = controlSis.listaPais();

            listaTipoCuenta = controlSis.listaTipoCuenta();

            cbxPais.Text = paisSelec;
            cbxTipoCuenta.Text = tipoCuentaSelect;

            dateCreacion.Enabled = false;
            dateCreacion.Value = cuentaMod.fechaCreacion;
       
        }

        private void cbxPais_Click(object sender, EventArgs e)
        {
            cbxPais.DataSource = paises;
            cbxPais.DisplayMember = "DESCRIPCION";

        }

        private void cbxTipoCuenta_Click(object sender, EventArgs e)
        {
            cbxTipoCuenta.DataSource = listaTipoCuenta;
            cbxTipoCuenta.DisplayMember = "DESCRIPCION";

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        { String campoSelec = comboBox3.SelectedItem.ToString();

        if (campoSelec == "SI" )
            {
                comboBox4.Visible = true;
                labelPeriodo.Visible = true;
            }
        else if (campoSelec == "NO")
        {
            comboBox4.Visible = false;
            labelPeriodo.Visible = false;
        }
        }

        private int transPeriodo(String selectPeriodo)
        {

             int periodo = 0;
            /* remplazar por case*/
            if (selectPeriodo == "DUPLICAR")
            {
                 periodo = 2;
            }
            if (selectPeriodo == "TRIPLICAR")
            {
                 periodo = 3;
            }
            if (selectPeriodo == "CUADRIPLICAR")
            {
                 periodo =4;
            }

            return periodo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pais paisSe = new Pais();
            decimal idPais;
            int idTipoC;
            DateTime fechaCierre;
            if(cbxPais.SelectedItem != null){
            paisSe = (Pais) cbxPais.SelectedItem;
                idPais= paisSe.id;
            }else {
                idPais = cuentaMod.idCuenta;
            }
            
            if(cbxTipoCuenta.SelectedItem != null){
                TipoCuenta tipoC= new TipoCuenta();
                tipoC = (TipoCuenta)cbxTipoCuenta.SelectedItem;
                 idTipoC = tipoC.id;
                 fechaCierre = Settings.Default.FechaActual;
              
            }else 
            {
                idTipoC= cuentaMod.tipoCuenta;
               /* fechaCierre = cuentaMod.FechaCierre;  sacar */
                fechaCierre = Settings.Default.FechaActual;
            }
            
            int periodo = transPeriodo(comboBox4.SelectedItem.ToString());


            controlCuenta.modCuenta(cuentaMod.idCuenta, paisSe.id, idTipoC, fechaCierre, periodo);

            MessageBox.Show("Se ha modificado correctamente");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Entidad;
using PagoElectronico.DAO;
using PagoElectronico.Controladores;

namespace PagoElectronico.PanelCliente
{
    public partial class PanelCliente : Form


         {

            public Usuario usuarioLogeado;
            public Cliente cliente;

        private SisDAO sisDAO;
        private ControladorCliente controladorCliente = new ControladorCliente();

        public PanelCliente()
        {
            InitializeComponent();
        }
        private void Cliente_Load(object sender, EventArgs e)
        {
            cliente = controladorCliente.buscarCliente(usuarioLogeado.id);
            loadCombo();

        }

        private void loadCombo()
        {
            sisDAO = new SisDAO();
            
            
            //tab Cuenta

            List<Cuenta> cuentas = new List<Cuenta>();
              cuentas = controladorCliente.buscarCuentaPorCliente(cliente.idCliente);
   
              listCuentaCuentas.DataSource = cuentas;
              listCuentaCuentas.DisplayMember = "IDCUENTA";


             List<Pais> paises = paises=sisDAO.listaPais();
           

            cbxCuentaPais.DataSource = paises;
            cbxCuentaPais.DisplayMember = "DESCRIPCION";
            cbxCuentaPais.Text = "Elegir una";

            List<TipoMoneda> tiposMonedas = sisDAO.listaTipoMoneda();

            cbxCuentaMoneda.DataSource = tiposMonedas;
            cbxCuentaMoneda.DisplayMember = "DESCRIPCION";
            cbxCuentaMoneda.Text = "Elegir una";

            //tabTarjeta Falta emisor

            //tab Saldo
            List<TipoDoc> tiposDoc = sisDAO.listaTipoDoc();
             cbxSaldoTipoDoc.DataSource= tiposDoc;
             cbxSaldoTipoDoc.DisplayMember = "DESCRIPCION";
             cbxSaldoTipoDoc.Text = "Elegir una";

            // tab Deposito 

             cbxTipoMoneda.DataSource = tiposMonedas;
             cbxTipoMoneda.DisplayMember = "DESCRIPCION";
             cbxTipoMoneda.Text = "Elegir una";

            //tab Retiro

             cbxRetiroTipoMoneda.DataSource = tiposMonedas;
             cbxRetiroTipoMoneda.DisplayMember = "DESCRIPCION";
             cbxRetiroTipoMoneda.Text = "Elegir una";

             cbxRetiroTipoDoc.DataSource = tiposDoc;
             cbxRetiroTipoDoc.DisplayMember = "DESCRIPCION";
             cbxRetiroTipoDoc.Text = "Elegir una";


           


        }

        private void btnAdmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Login login = new Login.Login();
            login.Visible = true;
           
        }
    
     
    }
}

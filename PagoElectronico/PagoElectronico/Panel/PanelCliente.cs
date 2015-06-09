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

namespace PagoElectronico.PanelCliente
{
    public partial class PanelCliente : Form

         {

        public Usuario usuario;

        private SisDAO sisDAO;

        public PanelCliente()
        {
            InitializeComponent();
        }
        private void Cliente_Load(object sender, EventArgs e)
        {
            loadCombo();

        }

        private void loadCombo()
        {
            sisDAO = new SisDAO();
            
            //tab Cuenta

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
    
     
    }
}

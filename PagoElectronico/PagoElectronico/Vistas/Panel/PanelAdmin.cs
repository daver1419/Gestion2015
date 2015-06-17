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


namespace PagoElectronico.Panel
{
    public partial class PanelAdmin : Form
    {
     

       private RolDAO rolDAO;

       private SisDAO sisDAO;
       private CuentaDao cuentaDao;
       private string _cliente;
        
        Rol rolSelect = new Rol();


        public PanelAdmin()
        {

            
            InitializeComponent();
            
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadCombo();
           
        }

        private void btnAltaClienteUsu_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabCliente;
            panelBusquedaUsu.Visible = false;

        }

        private void btnAddTarjeta_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabTarjeta;
            // llenar los label para cliente y  numero de cuenta 

            lblNcuentaTar.Text = txtNumeroCuenta.Text;
           


        }

        private void btnConfTarj_Click(object sender, EventArgs e)
        {
            btnAddTarjeta.Visible=true;
        }

        private void loadCombo()
        {
            rolDAO = new RolDAO();
            sisDAO = new SisDAO();
            // panel usuario
            List<Rol> dt = rolDAO.listaRol();
            cbxRol.DataSource = dt;
            cbxRol.DisplayMember = "DESCRIPCION";
            cbxRol.Text = "Elegir una";

            //panel Cliente
            List<Pais> paises = sisDAO.listaPais();
            cbxCliPais.DataSource = paises;
            cbxCliPais.DisplayMember = "DESCRIPCION";
            cbxCliPais.Text = "Elegir una";



            /*
            List<TipoDoc> tiposDoc = sisDAO.listaTipoDoc();
            cbxCliTipoDoc.DataSource = tiposDoc;
            cbxCliTipoDoc.DisplayMember = "DESCRIPCION";
            cbxCliTipoDoc.Text = "Elegir una";

            // panel Cuenta
            cbxPaisCuenta.DataSource = paises;
            cbxPaisCuenta.DisplayMember = "DESCRIPCION";
            cbxPaisCuenta.Text = "Elegir una";

            List<TipoMoneda> tiposMonedas = sisDAO.listaTipoMoneda();
            cbxMoneda.DataSource = tiposMonedas;
            cbxMoneda.DisplayMember = "DESCRIPCION";
            cbxMoneda.Text = "Elegir una";

            List<TipoCuenta> tiposCuentas = sisDAO.listaTipoCuenta();
            cbxTipoCuenta.DataSource = tiposCuentas;
            cbxTipoCuenta.DisplayMember = "DESCRIPCION";
            cbxTipoCuenta.Text = "Elegir una";
           
            // tab Tarjeta Falta el combo box 

            // tab Saldo 
            cbxTipoDocSaldo.DataSource = tiposDoc;
            cbxTipoDocSaldo.DisplayMember = "DESCRIPCION";
            cbxTipoDocSaldo.Text = "Elegir una";   */
        }

        private void cbxRol_SelectedValueChanged(object sender, EventArgs e)
        {         


                    
        }

        private void btnFunRol1_Click(object sender, EventArgs e)
        {
            rolSelect = (Rol)cbxRol.SelectedValue;

            rolDAO = new RolDAO();

            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            funcionalidades = rolDAO.listaFuncionalidad(rolSelect.id);

            lisboxFuncionalidades.DataSource = funcionalidades;
            lisboxFuncionalidades.DisplayMember = "DESCRIPCION";


        }

        private void button15_Click(object sender, EventArgs e)
        {
            cuentaDao = new CuentaDao();
            List<Cuenta> cuentas = cuentaDao.listaCuentas(Convert.ToInt32(_cliente));
            checkedListBox2.DataSource = cuentas;
            checkedListBox2.DisplayMember = "Cuentas";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox clienteTextBox = (TextBox)sender;
            _cliente = clienteTextBox.Text;

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Login login = new Login.Login();
            login.Visible = true;
        }


      
        
    }
}
        
     
      

        
       
      

      

     

      

        

       

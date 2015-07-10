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
using PagoElectronico.ABM_de_Usuario;


namespace PagoElectronico.Panel
{
    public partial class PanelAdmin : Form
    {
         public Usuario usuarioLogeado;

       private ControladorAdmin controladorAdmin = new ControladorAdmin();
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

           // lblNcuentaTar.Text = txtNumeroCuenta.Text;
           


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
            usuRolPicker.DataSource = dt;
            usuRolPicker.DisplayMember = "DESCRIPCION";
            usuRolPicker.Text = "Elegir una";

            //panel Cliente
            List<Pais> paises = sisDAO.listaPais();
            cliePaisPicker.DataSource = paises;
            cliePaisPicker.DisplayMember = "DESCRIPCION";
            cliePaisPicker.Text = "Elegir una";

           
            List<TipoDoc> tiposDoc = sisDAO.listaTipoDoc();
            cbxCliTipoDoc.DataSource = tiposDoc;
            cbxCliTipoDoc.DisplayMember = "DESCRIPCION";
            cbxCliTipoDoc.Text = "Elegir una";
            /*
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
            cbxTipoCuenta.Text = "Elegir una";*/
           
            // tab Tarjeta Falta el combo box 

            // tab Saldo 
            cbxTipoDocSaldo.DataSource = tiposDoc;
            cbxTipoDocSaldo.DisplayMember = "DESCRIPCION";
            cbxTipoDocSaldo.Text = "Elegir una";  
        }

        private void btnFunRol1_Click(object sender, EventArgs e)
        {
            rolSelect = (Rol)usuRolPicker.SelectedValue;

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

        private void btnAdmSalir_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(
                            new System.Threading.ThreadStart(loginForm));
            t.Start();
            this.Close();
        }

        private void loginForm()
        {
            Login.Login login = new Login.Login();
            Application.Run(login);
        }

        private void btnGuardarUsu_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(0, usuNameTxt.Text, usuContrasenaTxt.Text, 
                                               usuPreguntaSecTxt.Text, usuRespuestaSecTxt.Text,
                                               usuCreacionTxt.Value, usuModificacionTxt.Value, 
                                               (int)usuRolPicker.SelectedItem, false, null);
            controladorAdmin.guardarUsuario(usuario);
        }

        private void btnCliGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(clieNombreTxt.Text, clieApellidoTxt.Text, (int)cbxCliTipoDoc.SelectedItem,
                                           clieDocTxt.Text, clieMailTxt.Text, (String)cliePaisPicker.SelectedItem, clieCalleTxt.Text,
                                            clieNumTxt.Text, Convert.ToInt32(cliePisoTxt.Text), clieDepTxt.Text, clieLocalidTxt.Text,
                                            clieNacionalidadTxt.Text, clieNacimientoPicker.Value);
            controladorAdmin.guardarCliente(cliente);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
        
     
      

        
       
      

      

     

      

        

       

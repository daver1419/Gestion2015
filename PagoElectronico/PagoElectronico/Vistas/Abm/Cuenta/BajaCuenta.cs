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
using System.Data.SqlClient;

namespace PagoElectronico.Vistas.Abm.Cuenta
{
    public partial class BajaCuenta : Form
    {
        ControladorSis controlSis = new ControladorSis();
        ControladorCuenta controlCuenta = new ControladorCuenta();
        List<TipoDoc> lisTD = new List<TipoDoc>();
        DataTable dt = new DataTable();
        List<PagoElectronico.Entidad.Cuenta> listC = new List<PagoElectronico.Entidad.Cuenta>();
       
        decimal idTipoDocSeleccionado;
        decimal numeroDocSeleccionado; 

        public BajaCuenta()
        {
            InitializeComponent();
        }

        private void BajaCuenta_Load(object sender, EventArgs e)
        {
            lisTD = controlSis.listaTipoDoc();
            cbxTipoDoc.DataSource = lisTD;
            cbxTipoDoc.DisplayMember = "DESCRIPCION";
            cbxTipoDoc.Text = "Eliga una opción";

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            TipoDoc tdoc = new TipoDoc();
          
            tdoc =  (TipoDoc)cbxTipoDoc.SelectedItem;
            idTipoDocSeleccionado = tdoc.id;
            numeroDocSeleccionado = decimal.Parse (txtNum.Text);
           

            llenarDataTable(idTipoDocSeleccionado, numeroDocSeleccionado);
          
           
          }

        private void llenarDataTable(decimal idTipo, decimal numeroDoc)
        {
            Cuentas.Rows.Clear();
              Conexion conn = new Conexion();
                SqlDataReader resultado =
                conn.consultar("select  cuen_id ,esta_cuenta_desc ,cuen_saldo from THE_ULTIMATES.Cliente join THE_ULTIMATES.Cuenta  on cuen_clie_id= clie_id join THE_ULTIMATES.Estado_Cuenta on esta_cuenta_id=cuen_estado_id    where clie_nro_doc=" + numeroDoc.ToString() + "and clie_tipo_doc_id= " + idTipo.ToString());

            int renglon;
            while (resultado.Read())
            {
                renglon = Cuentas.Rows.Add();
                Cuentas.Rows[renglon].Cells["numero"].Value = resultado.GetDecimal(0);
                Cuentas.Rows[renglon].Cells["tipoCuenta"].Value = resultado.GetString(1);
                Cuentas.Rows[renglon].Cells["saldo"].Value = resultado.GetDecimal(2);

                DataGridViewImageCell iconColumn = (DataGridViewImageCell)Cuentas.Rows[renglon].Cells["editar"];
             

                iconColumn = (DataGridViewImageCell)Cuentas.Rows[renglon].Cells["eliminar"];
                
            }
            conn.desconectar();
           
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";

            Cuentas.Rows.Clear();

            idTipoDocSeleccionado = 0;
            numeroDocSeleccionado = 0;

        }

        private void Cuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {

            }
            else if (e.ColumnIndex == 4)
            {

                string numeroCuenta = Cuentas.Rows[e.RowIndex].Cells["numero"].Value.ToString();
                decimal numCuenta = Convert.ToDecimal(numeroCuenta);
                Conexion conn = new Conexion();
                SqlDataReader resultado = conn.consultar("update THE_ULTIMATES.Cuenta set cuen_estado_id = 3  where cuen_id =" + numCuenta);
                resultado.Dispose(); // Aca hago el borrado logico
                MessageBox.Show("Se ha dado de baja la cuenta", "");
                conn.desconectar();
                llenarDataTable(idTipoDocSeleccionado , numeroDocSeleccionado);

            }

        }

         





    }
}

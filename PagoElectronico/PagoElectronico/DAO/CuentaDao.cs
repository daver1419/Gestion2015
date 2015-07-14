using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Entidad;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Properties;

namespace PagoElectronico.DAO
{
    class CuentaDao : BaseDAO<Cuenta>
    {

        public List<Cuenta> listaCuentas(Int32 cliente)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            using (SqlCommand command = QueryPura("select * from THE_ULTIMATES.getCuentasByClieId(" + cliente + ")"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cuenta cuenta = new Cuenta();
                    cuenta.idCuenta= reader.GetDecimal(0);

                    cuentas.Add(cuenta);
                }
                CerrarConexion();
                return cuentas;
            }

        }


        public List<Cuenta> cuentasClie(decimal idtipoDoc, decimal numeroDoc)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
        try {

            using (SqlCommand command = InitializeConnection("SP_Cuentas_Cliente"))
            {
                command.Parameters.Add("@idTipoDoc", System.Data.SqlDbType.Decimal).Value = idtipoDoc;
                command.Parameters.Add("@numeroDoc", System.Data.SqlDbType.Decimal).Value = numeroDoc;

                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cuenta cuenta = new Cuenta();

                    cuenta.idCuenta = reader.GetDecimal(0);
                    cuenta.idCliente = reader.GetInt16(1);
                    cuenta.tipoCuenta = reader.GetInt16(2);
                    cuenta.fechaCreacion = reader.GetDateTime(3);
                    cuenta.FechaCierre = reader.GetDateTime(4);
                    cuenta.estadoId = reader.GetInt16(5);
                    cuenta.idPais = reader.GetInt16(6);
                    cuenta.cuentaSaldo = reader.GetInt16(7);
                    cuenta.tipoMoneda = reader.GetInt16(8);
                    cuentas.Add(cuenta);

                }
                
                return cuentas;
            }


            }catch (SqlException  e) {
                CerrarConexion();
                MessageBox.Show (e.Message);
                return cuentas;
            }
            }


        public void crearCuenta(decimal tipoDoc, decimal numeroDoc, int idTipoCuenta,
            decimal idPais, int tipoMoneda, int periodo)
        {
            try
            {
                using (SqlCommand command = InitializeConnection("SP_Alta_Cuentas_Cliente"))
                {
                    command.Parameters.Add("@idTipoDoc", System.Data.SqlDbType.Decimal).Value = tipoDoc;
                    command.Parameters.Add("@numeroDoc", System.Data.SqlDbType.Decimal).Value = numeroDoc;
                    command.Parameters.Add("@id_cuenta_tipo", System.Data.SqlDbType.Int).Value = idTipoCuenta;
                    command.Parameters.Add("@fech_creacion", System.Data.SqlDbType.DateTime).Value = Settings.Default.FechaActual;
                    command.Parameters.Add("@id_estado", System.Data.SqlDbType.Int).Value = 4;
                    command.Parameters.Add("@id_pais", System.Data.SqlDbType.Decimal).Value = idPais;
                    command.Parameters.Add("@saldo", System.Data.SqlDbType.Decimal).Value = 0;
                    command.Parameters.Add("@id_tipo_moneda", System.Data.SqlDbType.Int).Value = tipoMoneda;
                    command.Parameters.Add("@cantPeriodo", System.Data.SqlDbType.Int).Value = periodo;
                    SqlDataAdapter da = new SqlDataAdapter(command);

                    CerrarConexion();

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }


        public void modificarCuenta(decimal idCuenta, decimal idPais, int tipoCuenta, DateTime fechaCierre, int periodo)
        {
            using (SqlCommand command = InitializeConnection("SP_Mod_Cuenta"))
            {
                command.Parameters.Add("@idCuenta", System.Data.SqlDbType.Decimal).Value = idCuenta;
                command.Parameters.Add("@idpais", System.Data.SqlDbType.Decimal).Value = idPais;
                command.Parameters.Add("@tipocuenta", System.Data.SqlDbType.Int).Value = tipoCuenta;
                command.Parameters.Add("@fechaCierre", System.Data.SqlDbType.DateTime).Value = fechaCierre;
                command.Parameters.Add("@periodo", System.Data.SqlDbType.Int).Value = periodo;
      

                SqlDataAdapter da = new SqlDataAdapter(command);

                CerrarConexion();

            }
        }


        public void bajaCuenta(decimal idCuenta)
        {
            try
            {

                using (SqlCommand command = InitializeConnection("SP_Baja_Cuenta"))
                {
                    command.Parameters.Add("@idCuenta", System.Data.SqlDbType.Decimal).Value = idCuenta;
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    CerrarConexion();

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
       
    }
}

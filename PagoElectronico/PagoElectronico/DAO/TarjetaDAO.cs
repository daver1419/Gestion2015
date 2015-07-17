using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PagoElectronico.DAO
{
    class TarjetaDAO : BaseDAO<Cuenta>
    {
        public void agregarTarjeta( int idClie , string numero  ,int idEmisor , DateTime fechaEmi ,DateTime fechven, string codigo  )
        {


            using (SqlCommand command = InitializeConnection(""))
            {
                command.Parameters.Add("@idTipoDoc", System.Data.SqlDbType.Decimal).Value = idtipoDoc;
                command.Parameters.Add("@numeroDoc", System.Data.SqlDbType.Decimal).Value = numeroDoc;

                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cuenta cuenta = new Cuenta();

                    cuenta.idCuenta = reader.GetDecimal(0);
                    cuenta.idCliente = reader.GetInt32(1);
                    cuenta.tipoCuenta = reader.GetInt32(2);
                    cuenta.fechaCreacion = reader.GetDateTime(3);
                    cuenta.FechaCierre = reader.GetDateTime(4);
                    cuenta.estadoId = reader.GetInt32(5);
                    cuenta.idPais = reader.GetInt32(6);
                    cuenta.cuentaSaldo = reader.GetInt32(7);
                    cuenta.tipoMoneda = reader.GetInt32(8);
                    cuentas.Add(cuenta);

                }

                return cuentas;
            }



            
        }
    }
}

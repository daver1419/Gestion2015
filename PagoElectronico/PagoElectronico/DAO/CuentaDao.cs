using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Entidad;
using System.Data.SqlClient;

namespace PagoElectronico.DAO
{
    class CuentaDao : BaseDAO<Cuenta>
    {

        public List<Cuenta> listaCuentas(Int32 cliente)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            using (SqlCommand command = QueryPura("select * from THE_ULTIMATES.SP_getCuentasByClieId(" + cliente + ")"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cuenta cuenta = new Cuenta();
                    cuenta.numero = reader.GetDecimal(0);

                    cuentas.Add(cuenta);
                }
                CerrarConexion();
                return cuentas;
            }

        }
    }
}

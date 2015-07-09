using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Entidad;
using System.Data.SqlClient;

namespace PagoElectronico.DAO
{
    class ClienteDAO : BaseDAO<Cuenta>
    {

        public Cliente buscarCliente(Int32 idUsuario)
        {
            Cliente cliente = new Cliente();
            using (SqlCommand command = QueryPura("select * from THE_ULTIMATES.getClienteByUsuario(" + idUsuario + ")"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cliente.idCliente = reader.GetInt32(0);
                    cliente.nombre = reader.GetString(1);
                    cliente.apellido = reader.GetString(2);
                    cliente.numero = reader.GetDecimal(3).ToString();
                    cliente.tipoDoc = reader.GetDecimal(4).ToString();
                    cliente.mail = reader.GetString(5).ToString();
                    cliente.activo = reader.GetBoolean(6);
               }
                CerrarConexion();
                return cliente;
              }
            }
           }
}

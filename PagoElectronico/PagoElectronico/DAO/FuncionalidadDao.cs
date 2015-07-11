using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Entidad;
using System.Data.SqlClient;
using System.Data;

namespace PagoElectronico.DAO
{
    class FuncionalidadDao : BaseDAO<Funcionalidad>
    {
        public List<Funcionalidad> getFuncionalidades()
        {
            List<Funcionalidad> list = new List<Funcionalidad>();
            using (SqlCommand command = QueryPura("select * from THE_ULTIMATES.Funcionalidad"))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        { 
                            Funcionalidad funcionalidadAux = new Funcionalidad();

                            funcionalidadAux.id = (int)reader.GetValue(0);
                            funcionalidadAux.descripcion = (String)reader.GetValue(1);

                            list.Add(funcionalidadAux);
                        }
                    }
                }
                catch (Exception e)
                {
                }
                finally
                {
                    CerrarConexion();
                }

            }

            return list;
        }

    }
}

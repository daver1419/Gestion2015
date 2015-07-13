using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;
using PagoElectronico.Entidad;
using System.Text;

namespace PagoElectronico.DAO  
{
     class RolDAO : BaseDAO<Rol>
    {

        public RolDAO()
            : base(false)
        {

        }

        public RolDAO(bool conTransaccion)
            : base(conTransaccion)
        {

         }
       /* public Data listaRol()
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = InitializeConnection("Lista_rol"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            if (dt.Rows.Count > 0)
                return dt;
            return null;

        }*/

        public  List<Rol> listaRol()
        {
            List<Rol> lista = new List<Rol>();
            using (SqlCommand command = InitializeConnection("Lista_Rol"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Rol rol = new Rol();
                    rol.id = reader.GetInt32(0);
                    rol.descripcion = reader.GetString(1);
                   
                    lista.Add(rol);
                }
                CerrarConexion();
                return lista;
           }
       
        }

        internal void crearRol(string nombreRol, List<Funcionalidad> funcionalidades,
            Estado estado, PagoElectronico.Controladores.Controlador.Listener listener)
        {
            using (SqlCommand command = InitializeConnection("SP_crearRol"))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("func_id", typeof(int));

                foreach (Funcionalidad func in funcionalidades){
                    dt.Rows.Add(func.id);
                }

                command.Parameters.Add("@rol_descripcion", System.Data.SqlDbType.NVarChar, 15).Value = nombreRol;
                command.Parameters.Add("@funcionalidades", System.Data.SqlDbType.Structured).Value = dt;
                command.Parameters.Add("@estado", System.Data.SqlDbType.Bit).Value = estado.getEstado();

                SqlParameter parm1 = new SqlParameter("@code", SqlDbType.Int);
                parm1.Direction = ParameterDirection.Output;
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@msg", SqlDbType.NVarChar, 100);
                parm2.Direction = ParameterDirection.Output;
                command.Parameters.Add(parm2);

                SqlDataAdapter da = new SqlDataAdapter(command);
                try
                {
                    command.ExecuteNonQuery();
                    int code = (int)parm1.Value;
                    String msg = (String)parm2.Value;
                    listener.onCreateFinished(code, msg);

                }
                catch (Exception exec)
                {
                    int code = (int)parm1.Value;
                    String msg = (String)parm2.Value;
                    listener.onCreateError(code, msg);
                }
                finally
                {
                    CerrarConexion();
                }
            }  
            
        }

        internal List<Rol> getRoles(int codigoRol, string nombreRol, Funcionalidad funcionalidad, Estado estadoRol)
        {
            List<Rol> lista = new List<Rol>();

            StringBuilder query = new StringBuilder("select distinct R.rol_id, R.rol_desc, R.rol_activo from THE_ULTIMATES.Rol R");
            
            if(codigoRol != -1 || !String.IsNullOrEmpty(nombreRol) || funcionalidad != null || estadoRol != null){


                if (funcionalidad != null)
                {
                    query.Append(", THE_ULTIMATES.Funcionalidad_Rol F");
                }

                query.Append(" where ");

                if (codigoRol != -1)
                {
                    query.Append(" R.rol_id = ").Append(codigoRol);
                }

                if (!String.IsNullOrEmpty(nombreRol)) 
                {
                    if (codigoRol != -1)
                    {
                        query.Append(" and ");
                    }
                    query.Append(" R.rol_desc = '").Append(nombreRol).Append("'");
                }
                if (funcionalidad != null)
                {
                    if (codigoRol != -1 || !String.IsNullOrEmpty(nombreRol))
                    {
                        query.Append(" and ");
                    }
                    query.Append(" R.rol_id = F.func_rol_rol_id and F.func_rol_func_id = ").Append(funcionalidad.id);
                }
                if (estadoRol != null)
                {
                    if (codigoRol != -1 || !String.IsNullOrEmpty(nombreRol) || funcionalidad != null)
                    {
                        query.Append(" and ");
                    }
                    query.Append(" R.rol_activo = ").Append(estadoRol.getEstado());
                }
            }

            SqlCommand command = QueryPura(query.ToString());
        
            SqlDataAdapter da = new SqlDataAdapter(command);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Rol rol = new Rol();
                rol.id = (int)reader["rol_id"];
                rol.descripcion = (string)reader["rol_desc"];
                rol.estado = (bool)reader["rol_activo"];

                lista.Add(rol);
            }
            CerrarConexion();
            return lista;
            
        }
    }



}

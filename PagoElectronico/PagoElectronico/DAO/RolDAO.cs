using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;
using PagoElectronico.Entidad;

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



        public List<Funcionalidad> listaFuncionalidad(long idRol)
        {
            List<Funcionalidad> lista = new List<Funcionalidad>();
            using (SqlCommand command = InitializeConnection("Lista_Func_Rol"))

            {
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = idRol;
              

                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Funcionalidad funcionalidad = new Funcionalidad();

                    funcionalidad.descripcion = reader.GetString(0);

                    lista.Add(funcionalidad);


                }
                CerrarConexion();
                return lista;



            }





        }


        internal void crearRol(string nombreRol, List<Funcionalidad> funcionalidades,
            int estado, PagoElectronico.Controladores.Controlador.Listener listener)
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
                command.Parameters.Add("@estado", System.Data.SqlDbType.Bit).Value = estado;

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
    }



}

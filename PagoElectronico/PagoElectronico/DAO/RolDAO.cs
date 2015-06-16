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
                    rol.id = reader.GetByte(0);
                    rol.descripcion = reader.GetString(1);
                   
                    lista.Add(rol);
                }
                CerrarConexion();
                return lista;
           }
       
        }



        public List<Funcionalidad> listaFuncionalidad(int idRol)
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

    }



}

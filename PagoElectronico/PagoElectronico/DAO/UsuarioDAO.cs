using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PagoElectronico.Entidad;

namespace PagoElectronico.DAO
{
    class UsuarioDAO : BaseDAO<Usuario>
    {


        public List<Usuario> login(String username, String password)
        {
            List<Usuario> list = new List<Usuario>();

             

             using (SqlCommand command = InitializeConnection("login"))
            {
                command.Parameters.Add("@usuario", System.Data.SqlDbType.NVarChar, 25).Value = username;
                command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 64).Value = password;
          

 
                SqlDataAdapter da = new SqlDataAdapter(command);
                

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = reader.GetInt32(0);
                    usuario.usuario = reader.GetString(1);
                    usuario.habilitado = reader.GetBoolean(2);
                    usuario.rol = reader.GetInt32(3);

                    list.Add(usuario);

                } 
                 
                 CerrarConexion();
                 return list;




            }  

            
           
        }

        internal void guardarCliente(Usuario datos)
        {


            using (SqlCommand command = InitializeConnection("guardarCliente"))
            {
                command.Parameters.Add("@usuario", System.Data.SqlDbType.NVarChar, 20).Value = datos.usuario;
                command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 64).Value = datos.contrasena;
                command.Parameters.Add("@fechaAlta", System.Data.SqlDbType.DateTime, 64).Value = datos.fechaCreacion;
                command.Parameters.Add("@fechaModificacion", System.Data.SqlDbType.NVarChar, 64).Value = datos.fechaModificacion;
                command.Parameters.Add("@preguntaSecreta", System.Data.SqlDbType.NVarChar, 50).Value = datos.preguntaSec;
                command.Parameters.Add("@respuestaSecreta", System.Data.SqlDbType.NVarChar, 64).Value = datos.respuestaSec;

                SqlDataAdapter da = new SqlDataAdapter(command);
                
                CerrarConexion();
        }
    }
}

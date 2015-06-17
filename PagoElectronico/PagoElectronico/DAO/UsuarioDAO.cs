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


    }
}

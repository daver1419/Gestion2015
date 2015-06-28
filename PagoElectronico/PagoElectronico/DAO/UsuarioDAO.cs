using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PagoElectronico.Entidad;
using PagoElectronico.Properties;
using System.Data;
using System.Windows.Forms;

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

        public void crearUsuarioPosible(String username, String pass, Boolean esUsuarioPosible)
        {
              List<Usuario> list = new List<Usuario>();
              using (SqlCommand command = InitializeConnection("SP_Crear_usu_posible"))
              {

                  try
                  {
                      DataTable dt = new DataTable();
                      command.Parameters.Add("@usuname", System.Data.SqlDbType.NVarChar, 25).Value = username;
                      command.Parameters.Add("@pass", System.Data.SqlDbType.Char, 64).Value = pass;
                      command.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime).Value = Settings.Default.FechaActual;

                      SqlDataAdapter da = new SqlDataAdapter(command);
                      

                      SqlDataReader reader = command.ExecuteReader();

                      MessageBox.Show("Se ha creado correctamente el usuario: " + username);
                      CerrarConexion();
                  }
                  catch (Exception e)
                  {
                      MessageBox.Show( "Ya existe el usuario: " +username);
                      CerrarConexion();
                      
                      
                  }
              }
        }



    }
}

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
<<<<<<< HEAD
           using (SqlCommand command = InitializeConnection("login"))
            {
                command.Parameters.Add("@usuario", System.Data.SqlDbType.NVarChar, 25).Value = username;
                command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 64).Value = password;
                SqlDataAdapter da = new SqlDataAdapter(command);
=======



            using (SqlCommand command = InitializeConnection("login"))
            {
                command.Parameters.Add("@usuario", System.Data.SqlDbType.NVarChar, 25).Value = username;
                command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 64).Value = password;



                SqlDataAdapter da = new SqlDataAdapter(command);


>>>>>>> 127bd5342b40b6e6abb4fad1bb0eef9474bab2cc
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   Usuario usuario = new Usuario();
                    usuario.id = reader.GetInt32(0);
                    usuario.usuario = reader.GetString(1);
                    usuario.habilitado = reader.GetBoolean(2);
                    usuario.rol = reader.GetInt32(3);
                    list.Add(usuario);
<<<<<<< HEAD
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
=======

                }

                CerrarConexion();
                return list;




            }



>>>>>>> 127bd5342b40b6e6abb4fad1bb0eef9474bab2cc
        }

        internal void guardarUsuario(Usuario datos)
        {


            using (SqlCommand command = InitializeConnection("guardarUsuario"))
            {
                command.Parameters.Add("@usu_username", System.Data.SqlDbType.NVarChar, 20).Value = datos.usuario;
                command.Parameters.Add("@usu_password", System.Data.SqlDbType.NVarChar, 64).Value = datos.contrasena;
                command.Parameters.Add("@usu_fecha_alta", System.Data.SqlDbType.DateTime, 64).Value = datos.fechaCreacion;
                command.Parameters.Add("@usu_fecha_mod", System.Data.SqlDbType.NVarChar, 64).Value = datos.fechaModificacion;
                command.Parameters.Add("@usu_pregunta", System.Data.SqlDbType.NVarChar, 50).Value = datos.preguntaSec;
                command.Parameters.Add("@usu_respuesta", System.Data.SqlDbType.NVarChar, 64).Value = datos.respuestaSec;
                // Clie ID? Activo? Intentos fallidos?
                SqlDataAdapter da = new SqlDataAdapter(command);

<<<<<<< HEAD

=======
                CerrarConexion();
            }
        }


        internal void guardarCliente(Cliente datos)
        {


            using (SqlCommand command = InitializeConnection("guardarCliente"))
            {
                command.Parameters.Add("@clie_nombre", System.Data.SqlDbType.NVarChar, 50).Value = datos.nombre;
                command.Parameters.Add("@clie_apellido", System.Data.SqlDbType.NVarChar, 50).Value = datos.apellido;
                command.Parameters.Add("@clie_nro_doc", System.Data.SqlDbType.Int, 64).Value = datos.dni;
                command.Parameters.Add("@clie_tipo_doc_id", System.Data.SqlDbType.SmallInt, 64).Value = datos.tipoDoc; //FK?
                command.Parameters.Add("@clie_mail", System.Data.SqlDbType.NVarChar, 50).Value = datos.mail;
                command.Parameters.Add("@clie_dom_calle", System.Data.SqlDbType.NVarChar, 64).Value = datos.calle;
                command.Parameters.Add("@clie_dom_numero", System.Data.SqlDbType.NVarChar, 64).Value = datos.numero;
                command.Parameters.Add("@clie_dom_piso", System.Data.SqlDbType.NVarChar, 64).Value = datos.piso;
                command.Parameters.Add("@clie_dom_depto", System.Data.SqlDbType.NVarChar, 64).Value = datos.departamento;
                command.Parameters.Add("@clie_fecha_nac", System.Data.SqlDbType.NVarChar, 64).Value = datos.fechaDeNacimiento;
                command.Parameters.Add("@clie_pais_id", System.Data.SqlDbType.NVarChar, 64).Value = datos.nacionalidad; // FK?
                // Activo?

                SqlDataAdapter da = new SqlDataAdapter(command);

                CerrarConexion();
            }
        }
>>>>>>> 127bd5342b40b6e6abb4fad1bb0eef9474bab2cc
    }
}

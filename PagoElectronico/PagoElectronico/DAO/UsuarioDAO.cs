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
                    usuario.username = reader.GetString(1);
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
                     
                      MessageBox.Show( "Ya existe el usuario: " + username);
                      CerrarConexion();
              
                  }
              }
     
        }

        internal void crearUsuario(String username, String contrasena, String preguntaSec, 
            String respuestaSec, int rolId, PagoElectronico.Controladores.Controlador.Listener listener)
        {

            using (SqlCommand command = InitializeConnection("SP_crearUsuario"))
            {
                

                command.Parameters.Add("@usu_username", System.Data.SqlDbType.NVarChar, 25).Value = username;
                command.Parameters.Add("@usu_password", System.Data.SqlDbType.NVarChar, 64).Value = contrasena;
                command.Parameters.Add("@usu_pregunta", System.Data.SqlDbType.NVarChar, 50).Value = preguntaSec;
                command.Parameters.Add("@usu_respuesta", System.Data.SqlDbType.NVarChar, 64).Value = respuestaSec;
                command.Parameters.Add("@rol_id", System.Data.SqlDbType.Int).Value = rolId;

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
                catch(Exception exec)
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

    }
}

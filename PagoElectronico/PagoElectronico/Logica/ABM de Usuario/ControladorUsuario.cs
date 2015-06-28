using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Entidad;
using PagoElectronico.DAO;
using System.Windows.Forms;

namespace PagoElectronico.ABM_de_Usuario
{
    class ControladorUsuario
    {
        UsuarioDAO usuDAO = new UsuarioDAO();

        public void crearClientePosible(String usuario, String contrasena, Boolean usuarioPosible)
        {
                     usuDAO.crearUsuarioPosible(usuario, contrasena, usuarioPosible);

                    
        }
        public List<Usuario> buscarUsuario(String usuario, String contrasena)
        {
            
           
            return (usuDAO.login(usuario, contrasena));
                      
        }


    }
}

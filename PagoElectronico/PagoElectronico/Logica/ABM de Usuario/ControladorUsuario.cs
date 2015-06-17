using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Entidad;
using PagoElectronico.DAO;

namespace PagoElectronico.ABM_de_Usuario
{
    class ControladorUsuario
    {

        public void crearClientePosible(String usuario, String contrasena, Boolean usuarioPosible)
        {
        }
        public List<Usuario> buscarUsuario(String usuario, String contrasena)
        {
            UsuarioDAO usuDAO = new UsuarioDAO();
           
            return (usuDAO.login(usuario, contrasena));
                      
        }


    }
}

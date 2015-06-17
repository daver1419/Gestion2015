using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using PagoElectronico.Entidad;

namespace PagoElectronico.ABM_de_Usuario
{
    class ControladorUsuario
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public void crearClientePosible(String usuario, String contraseña)
        {
        }

        public List<Usuario> login(String usuario,  String contraseña)
        {
            return usuarioDAO.login(usuario, contraseña);
        }
    }
}

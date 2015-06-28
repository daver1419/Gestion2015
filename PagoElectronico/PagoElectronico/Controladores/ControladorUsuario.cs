using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using PagoElectronico.Entidad;

// Controla todos los tabs del Admin

namespace PagoElectronico.ABM_de_Usuario
{
    class ControladorAdmin
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public List<Usuario> login(String usuario,  String contraseña)
        {
            return usuarioDAO.login(usuario, contraseña);
        }

        internal void guardarUsuario(Usuario usuario)
        {
            usuarioDAO.guardarUsuario(usuario);
        }

        internal void guardarCliente(Cliente cliente)
        {
            usuarioDAO.guardarCliente(cliente);
        }

        internal void crearClientePosible(string nombre, string password)
        {
            Boolean usuPosible = true;
            usuarioDAO.crearUsuarioPosible( nombre , password ,usuPosible);

        }
    }
}


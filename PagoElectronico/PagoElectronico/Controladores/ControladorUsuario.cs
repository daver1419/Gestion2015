using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using PagoElectronico.Entidad;

// Controla todos los tabs del Admin

namespace PagoElectronico.Controladores
{
    class ControladorUsuario : Controlador
    {
       
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        RolDAO rolDAO = new RolDAO();

        public List<Usuario> login(String usuario,  String contraseña)
        {
            return usuarioDAO.login(usuario, contraseña);
        }

        internal void crearUsuario(String username, String contrasena,
            String preguntaSec, String respuestaSec, int rolId, Listener listener)
        {
             usuarioDAO.crearUsuario(username, 
                Utilitario.Util.GetSHA256Encriptado(contrasena), preguntaSec,
                Utilitario.Util.GetSHA256Encriptado(respuestaSec), rolId, listener);
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


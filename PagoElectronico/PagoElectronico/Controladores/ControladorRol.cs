using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using PagoElectronico.Entidad;

namespace PagoElectronico.Controladores
{
    class ControladorRol : Controlador
    {
        RolDAO rolDAO = new RolDAO();

        FuncionalidadDao funcionalidadDAO = new FuncionalidadDao();

        public void crearRol(String nombreRol, List<Funcionalidad> funcionalidades, Estado estado, Listener listener)
        {
            rolDAO.crearRol(nombreRol, funcionalidades, estado, listener);
        }

        internal List<Funcionalidad> getFuncionalidades()
        {
            return funcionalidadDAO.getFuncionalidades();
        }

        internal List<Rol> getRoles()
        {
            return rolDAO.listaRol();
        }

        internal List<Funcionalidad> getFuncionalidadesByRolId(int rolId)
        {
            return funcionalidadDAO.getFuncionalidadesByRolId(rolId);
        }

        internal List<Rol> getRoles(int codigoRol, String nombreRol, Funcionalidad funcionalidad, Estado estadoRol)
        {
            return rolDAO.getRoles(codigoRol, nombreRol, funcionalidad, estadoRol);
        }


    }
}

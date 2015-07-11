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

        public void crearRol(String nombreRol, List<Funcionalidad> funcionalidades, int estado, Listener listener)
        {
            rolDAO.crearRol(nombreRol, funcionalidades, estado, listener);
        }

        internal List<Funcionalidad> getFuncionalidades()
        {
            return funcionalidadDAO.getFuncionalidades();
        }
        
    
    
    }
}

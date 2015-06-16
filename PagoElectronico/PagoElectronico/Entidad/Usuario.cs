using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidad
{
   public class Usuario
    {
        private String usuario;
        private String contrasena;
        private String preguntaSec;
        private String respuestaSec;
        private String rol;
        private Boolean habilitado;
        private Cliente cliente;

        public String getUsuario()
        {
            return usuario;
        }

        public String getContrasena()
        {
            return contrasena;
        }

        public String getRol()
        {
            return rol;
        }



    }
}

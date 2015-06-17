using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidad
{
    public class Usuario
    {
        public long id { get; set; }
        public String usuario { get; set; }
        public String contrasena { get; set; }
        public String preguntaSec { get; set; }
        public String respuestaSec { get; set; }
        public int rol { get; set; }
        public Boolean habilitado { get; set; }
        public Cliente cliente { get; set; }





    }
      
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidad
{
    class Funcionalidad
    {
        public int id { get; set; }
        public String descripcion { get; set; }

        public override String ToString(){
            return descripcion;
        }
    }
}

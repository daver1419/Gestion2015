using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidad
{
    class Estado
    {
        public String tipo { get; set; }

        public Estado(String tipo)
        {
            this.tipo = tipo;
        }

        public int getEstado()
        {
            return tipo.Equals("Activo") ? 1:0;
        }

        public override string ToString()
        {
            return tipo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidad
{
    class Cuenta
    {
        public decimal idCuenta { get; set; }
        public int idCliente { get; set; }
        public  int tipoCuenta {get; set;}
        public DateTime fechaCreacion { get; set; }
        public DateTime FechaCierre { get; set; }
        public int estadoId { get; set; }
        public decimal idPais { get; set; }
        public decimal cuentaSaldo { get; set; }
        public int tipoMoneda { get; set; }
       
    }
}

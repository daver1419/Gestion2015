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
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public Cliente cliente { get; set; }

        public Usuario();

        public Usuario(long id, String usuario, String contrasena, String preguntaSec, String respuestaSec,
            DateTime fechaCreacion, DateTime fechaModificacion,
           int rol, Boolean habilitado, Cliente cliente){
               this.id = id;
               this.usuario = usuario;
               this.contrasena = contrasena;
               this.preguntaSec = preguntaSec;
               this.respuestaSec = respuestaSec;
               this.fechaCreacion = fechaCreacion;
               this.fechaModificacion = fechaModificacion;
               this.rol = rol;
               this.habilitado = habilitado;
               this.cliente = cliente;
    }



    }
      
}

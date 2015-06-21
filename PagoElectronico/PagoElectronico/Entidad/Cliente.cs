using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidad
{
    public class Cliente
    {

        public String nombre { get; set; }
        public String apellido { get; set; }
        public int dni { get; set; }
        public String tipoDoc { get; set; }
        public String mail { get; set; }
        public String pais { get; set; }
        public String calle { get; set; }
        public String numero { get; set; }
        public int piso { get; set; }
        public String departamento { get; set; }
        public String localidad { get; set; }
        public String nacionalidad { get; set; }
        public DateTime fechaDeNacimiento { get; set; }
     

    public Cliente(String nombre, String apellido,
         int dni,String tipoDoc, String mail, String pais, String calle, String numero, int piso,
         String departamento, String localidad, String nacionalidad, DateTime fechaDeNacimiento){
    this.nombre = nombre;
    this.apellido = apellido;
    this.tipoDoc = tipoDoc;
    this.mail = mail;
    this.pais = pais;
    this.calle = calle;
    this.numero = numero;
    this.piso = piso;
    this.departamento = departamento;
    this.localidad = localidad;
    this.nacionalidad = nacionalidad;
    this.fechaDeNacimiento = fechaDeNacimiento;

    }

    }

}

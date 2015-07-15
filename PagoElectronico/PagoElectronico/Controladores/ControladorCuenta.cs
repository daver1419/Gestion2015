using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using PagoElectronico.Entidad;
using System.Data;

namespace PagoElectronico.Controladores
{
    class ControladorCuenta
    {
        CuentaDao cuentaDao = new CuentaDao();
        public  List<Cuenta> consultaCuentaCli(decimal tipoDoc, decimal numDoc)
        {
           return cuentaDao.cuentasClie(tipoDoc, numDoc);

        }
        public void altaCuenta( decimal tipoDoc , decimal numDoc , int tipoCuenta , decimal idPais , int idMoneda , int periodo)
        {
            cuentaDao.crearCuenta(tipoCuenta, numDoc, tipoCuenta, idPais, idMoneda , periodo);
        }
        public void bajaCuenta( decimal idCuenta)
        {
            cuentaDao.bajaCuenta(idCuenta);
        }

         public DataTable cuentasParaCli(decimal  tipoDoc, decimal numDoc){
           return  cuentaDao.cuentasCli(tipoDoc, numDoc);
         }


    }
}

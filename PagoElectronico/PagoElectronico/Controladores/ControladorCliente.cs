using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using PagoElectronico.Entidad;

namespace PagoElectronico.Controladores
{
    class ControladorCliente : Controlador
    {
        public CuentaDao cuentaDao;
        public ClienteDAO clienteDao;

        public Cliente buscarCliente(Int32 idUsuario)
        {
            clienteDao = new ClienteDAO();

            return clienteDao.buscarCliente(idUsuario);

        }

        public List<Cuenta> buscarCuentaPorCliente (Int32 cliente){

            cuentaDao = new CuentaDao();
            List<Cuenta> cuentas = new List<Cuenta>();

            cuentas = cuentaDao.listaCuentas(cliente);

            return cuentas;


            }


    }
}

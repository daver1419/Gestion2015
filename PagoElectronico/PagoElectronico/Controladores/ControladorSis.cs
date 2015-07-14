using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using PagoElectronico.Entidad;

namespace PagoElectronico.Controladores
{
    class ControladorSis
    {

        SisDAO sisDao = new SisDAO();

        public List<TipoDoc> listaTipoDoc()
        {
            return sisDao.listaTipoDoc();

        }
        public List<Pais> listaPais()
        {
            return sisDao.listaPais();
        }
        public List<TipoCuenta> listaTipoCuenta()
        {
            return sisDao.listaTipoCuenta();
        }

        public List<TipoMoneda> listaTipoMoneda()
        {
            return sisDao.listaTipoMoneda();
        }

    }
}

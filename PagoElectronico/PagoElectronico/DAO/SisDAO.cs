using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Entidad;
using System.Data.SqlClient;

namespace PagoElectronico.DAO
{
    class SisDAO : BaseDAO<Sis>

    {
        public List<Pais> listaPais()
        {
            List<Pais> lista = new List<Pais>();
            using (SqlCommand command = InitializeConnection("Lista_Pais"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Pais pais = new Pais();
                    pais.id = reader.GetDecimal(0);
                    pais.descripcion = reader.GetString(1);
                    lista.Add(pais);

                  
                }
                CerrarConexion();
                return lista;
            }

        }
        public List<TipoCuenta> listaTipoCuenta()
        {
            List<TipoCuenta> lista = new List<TipoCuenta>();
            using (SqlCommand command = InitializeConnection("Lista_Tipo_Cuenta"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TipoCuenta tipoCuenta = new TipoCuenta();
                    tipoCuenta.id = reader.GetInt32(0);
                    tipoCuenta.descripcion = reader.GetString(1);
                    lista.Add(tipoCuenta);

                }
                CerrarConexion();
                return lista;
            }

        }
        public List<TipoDoc> listaTipoDoc()
        {
            List<TipoDoc> lista = new List<TipoDoc>();
            using (SqlCommand command = InitializeConnection("Lista_Tipo_Doc"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TipoDoc tipoDoc = new TipoDoc();
                    tipoDoc.id = reader.GetDecimal(0);
                    tipoDoc.descripcion = reader.GetString(1);

                    lista.Add(tipoDoc);

                }
                CerrarConexion();
                return lista;
            }

        }
        public List<TipoMoneda> listaTipoMoneda()
        {
            List<TipoMoneda> lista = new List<TipoMoneda>();
            using (SqlCommand command = InitializeConnection("Lista_Tipo_Moneda"))
            {
                SqlDataAdapter da = new SqlDataAdapter(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TipoMoneda tipoMoneda = new TipoMoneda();
                    tipoMoneda.id = reader.GetInt32(0);
                    tipoMoneda.descripcion = reader.GetString(1);
                    lista.Add(tipoMoneda);

                }
                CerrarConexion();
                return lista;
            }

        }
    }
}

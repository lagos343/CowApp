using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdUsuarios
    {
        //Propiedades
        private SqlConecct sqlConexion = new SqlConecct();
        protected DataTable registrosUsuarios;
        private SqlDataAdapter adapterSql;

        //Metodos
        public DataTable ObtenerRegistros(string cadenaConsulta)
        {
            adapterSql = new SqlDataAdapter(cadenaConsulta, sqlConexion.AbrirConeccion());
            registrosUsuarios = new DataTable();
            try { adapterSql.Fill(registrosUsuarios); }
            catch (Exception) { }
            sqlConexion.CerrarConeccion();

            return registrosUsuarios;
        }
    }
}

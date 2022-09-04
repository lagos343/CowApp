using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdUsuarioLogueado
    {
        //Propiedades
        private SqlConecct sqlConexion = new SqlConecct();        
        protected DataTable registrosLogin;
        private SqlDataAdapter adapterSql;        

        //Metodos
        public DataTable ObtenerLogin(string cadenaConsulta)
        {
            adapterSql = new SqlDataAdapter(cadenaConsulta, sqlConexion.AbrirConeccion());
            registrosLogin = new DataTable();
            try { adapterSql.Fill(registrosLogin); }
            catch (Exception) { }
            sqlConexion.CerrarConeccion();

            return registrosLogin;            
        }
    }
}

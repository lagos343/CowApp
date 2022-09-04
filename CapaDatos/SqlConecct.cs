using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class SqlConecct
    {
        private SqlConnection coneccionSql = new SqlConnection("Server = localhost; DataBase = Agropecuaria; integrated security = true");

        public SqlConnection AbrirConeccion()
        {
            if (coneccionSql.State == ConnectionState.Closed) coneccionSql.Open();
            return coneccionSql;
        }

        public SqlConnection CerrarConeccion()
        {
            if (coneccionSql.State == ConnectionState.Open) coneccionSql.Close();
            return coneccionSql;
        }
    }
}

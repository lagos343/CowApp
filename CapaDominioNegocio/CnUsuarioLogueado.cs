using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaDominioNegocio
{
    public class CnUsuarioLogueado
    {
        //Clases
        private CdUsuarioLogueado usuarioLogueado = new CdUsuarioLogueado();

        //propiedades
        private static string nombreUsuario;
        private static string contraUsuario;
        DataTable registroUsuario;

        #region Encapsulado de Variables

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ContraUsuario { get => contraUsuario; set => contraUsuario = value; }

        #endregion

        //metodos
        public bool PermitirLogueo()
        {             
            string cadenaConsulta = "select nombre_usuario, convert(nvarchar, DECRYPTBYPASSPHRASE('TecnoPc', clave_usuario)) from Usuarios " +
                "where nombre_usuario = '" + nombreUsuario.ToString() + "' and estado_usuario = 1";
            registroUsuario = new DataTable();
            registroUsuario = usuarioLogueado.ObtenerLogin(cadenaConsulta);

            try
            {
                if (nombreUsuario == registroUsuario.Rows[0][0].ToString() && contraUsuario == registroUsuario.Rows[0][1].ToString()) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaDominioNegocio
{
    public class CnUsuarios
    {
        //Clases
        CdUsuarios usuarios = new CdUsuarios();

        //Propiedades
        DataTable registrosUsuarios;
        private string idUsuario;
        private string idRol;
        private string idEmpleado;
        private string nombreUsuario;
        private string claveUsuario;

        #region Encapsulamiento de Propiedades

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string IdRol { get => idRol; set => idRol = value; }
        public string IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ClaveUsuario { get => claveUsuario; set => claveUsuario = value; }

        #endregion

        //Metodos
        public DataTable ObtenerListaUsuarios()
        {
            registrosUsuarios = usuarios.ObtenerRegistros("select u.id_usuario, u.nombre_usuario as Usuario, (e.nombre_empleado + ' ' + e.apellido_empleado) " +
                "as Propietario, r.nombre_rol as Rol from Usuarios u inner join Roles r on r.id_rol = u.id_rol inner join Empleados e on e.id_empleado = " +
                "u.id_empleado where estado_usuario = 1");

            return registrosUsuarios;
        }

        public DataTable ObtenerListaEmpleados()
        {
            registrosUsuarios = usuarios.ObtenerRegistros("select id_empleado, (nombre_empleado +' '+apellido_empleado) as Empleado from Empleados " +
                "where estado_empleado = 1");
            return registrosUsuarios;
        }

        public DataTable ObtenerListaRoles()
        {
            registrosUsuarios = usuarios.ObtenerRegistros("select *from Roles");
            return registrosUsuarios;
        }

        public DataRow ObtenerUsuarioMedianteId()
        {
            registrosUsuarios = usuarios.ObtenerRegistros("select id_usuario, id_rol, id_empleado, nombre_usuario, CONVERT(nvarchar, DECRYPTBYPASSPHRASE('TecnoPc', " +
                "clave_usuario)) as contraseña from Usuarios where estado_usuario = 1 and id_usuario = " + idUsuario);
            return registrosUsuarios.Rows[0];
        }
    }
}

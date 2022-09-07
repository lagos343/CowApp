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

        //Metodos
        public DataTable ObtenerListaUsuarios()
        {
            registrosUsuarios = usuarios.ObtenerUsuarios("select u.id_usuario, u.nombre_usuario as Usuario, (e.nombre_empleado + ' ' + e.apellido_empleado) " +
                "as Propietario, r.nombre_rol as Rol from Usuarios u inner join Roles r on r.id_rol = u.id_rol inner join Empleados e on e.id_empleado = " +
                "u.id_empleado where estado_usuario = 1");

            return registrosUsuarios;
        }
    }
}

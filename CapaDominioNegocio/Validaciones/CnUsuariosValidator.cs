using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;

namespace CapaDominioNegocio.Validaciones
{
    public class CnUsuariosValidator : AbstractValidator<CnUsuarios>
    {
        public CnUsuariosValidator()
        {            
            RuleFor(r => long.Parse(r.IdRol)).NotEqual(0).WithMessage("Rol sin selecionar");

            RuleFor(r => long.Parse(r.IdEmpleado)).NotEqual(0).WithMessage("Empleado sin selecionar");

            RuleFor(r => r.NombreUsuario).NotEmpty().WithMessage("Nombre de Usuario vacio").
                MinimumLength(5).WithMessage("Nombre de Usuario debe ser mayor a\n   4 Carcateres").
                Must(ValidarNombreUsuario).WithMessage("Nombre de Usuario solo acepta Letras").
                Must(ValidarMayusculasNombreUsuario).WithMessage("Nombre de Usuario debe tener al menos\n   una mayuscula");

            RuleFor(r => r.ClaveUsuario).NotEmpty().WithMessage("Contraseña vacia").
                MinimumLength(5).WithMessage("Contraseña debe ser mayor a 7\n   Carcateres").
                Must(ValidarFormatoContraseñaUsuario).WithMessage("Contraseña debe tener al menos una\n   mayuscula, una minuscula, un numero y\n  un carcater especial (* _  -  #)");
        }

        private bool ValidarNombreUsuario(string nombreUsuario)
        {
            if (Regex.Replace(nombreUsuario, "[A-Z, a-z]", string.Empty).Length == 0) return true;
            else return false;
        }

        private bool ValidarMayusculasNombreUsuario(string nombreUsuario)
        {
            if (Regex.IsMatch(nombreUsuario, "[A-Z]")) return true;
            else return false;
        }

        private bool ValidarFormatoContraseñaUsuario(string contraseña)
        {
            if (Regex.IsMatch(contraseña, "[A-Z]") && Regex.IsMatch(contraseña, "[a-z]") && Regex.IsMatch(contraseña, "[0-9]") 
                && Regex.IsMatch(contraseña, "[*, _, -, #,]")) return true;
            else return false;
        }
    }
}

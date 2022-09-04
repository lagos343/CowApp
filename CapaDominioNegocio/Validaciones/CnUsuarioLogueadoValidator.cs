using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace CapaDominioNegocio.Validaciones
{
    public class CnUsuarioLogueadoValidator : AbstractValidator<CnUsuarioLogueado>
    {
        public CnUsuarioLogueadoValidator()
        {
            RuleFor(r => r.NombreUsuario).NotEmpty().WithMessage("Nombre de usuario vacio");
            RuleFor(r => r.ContraUsuario).NotEmpty().WithMessage("Contraseña vacia");
        }
    }
}

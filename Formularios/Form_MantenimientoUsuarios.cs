using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominioNegocio.Validaciones;
using CapaDominioNegocio;
using CapaPresentacion.RjMessageBox;

namespace CapaPresentacion.Formularios
{
    public partial class Form_MantenimientoUsuarios : Form
    {
        CnUsuarios usuarios = new CnUsuarios();
        bool NuevoRegistro = true;
        DataRow filaUsuario;

        public Form_MantenimientoUsuarios(bool nuevoRegistro, string idUsuario = null)
        {
            InitializeComponent();
            CargarCombobox();

            if (nuevoRegistro)
            {                
                lbl_tituloMantenimiento.Text = "Añadir nuevo Usuario";
                NuevoRegistro = true;
            }
            else
            {
                lbl_tituloMantenimiento.Text = "Editar Usuario";
                NuevoRegistro = !true;

                //cargando datos
                usuarios.IdUsuario = idUsuario;
                filaUsuario = usuarios.ObtenerUsuarioMedianteId();
                txt_id.Texts = filaUsuario[0].ToString();
                cbo_rol.SelectedValue = filaUsuario[1].ToString();
                cbo_empleado.SelectedValue = filaUsuario[2].ToString();
                txt_nombreUsuario.Texts = filaUsuario[3].ToString();
                txt_contraseña.Texts = filaUsuario[4].ToString();
            }
        }       

        private void CargarCombobox()
        {
            //metodos para llenar los combobox
            //empleado
            cbo_empleado.DataSource = usuarios.ObtenerListaEmpleados();
            cbo_empleado.ValueMember = "id_empleado";
            cbo_empleado.DisplayMember = "Empleado";

            //roles
            cbo_rol.DataSource = usuarios.ObtenerListaRoles();
            cbo_rol.ValueMember = "id_rol";
            cbo_rol.DisplayMember = "nombre_rol";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //instancia de las clases de validacion
            var validadorUsuario = new CnUsuariosValidator();

            //mandamos los datos a la clase
            usuarios.IdUsuario = txt_id.Texts;
            if (cbo_rol.SelectedValue != null) usuarios.IdRol = cbo_rol.SelectedValue.ToString();
            else usuarios.IdRol = "0";
            if (cbo_empleado.SelectedValue != null) usuarios.IdEmpleado = cbo_empleado.SelectedValue.ToString();
            else usuarios.IdEmpleado = "0";
            usuarios.NombreUsuario = txt_nombreUsuario.Texts;
            usuarios.ClaveUsuario = txt_contraseña.Texts;

            //extraemos el resultado de la validacion de la clase
            var resultadosValidacion = validadorUsuario.Validate(usuarios);

            if (resultadosValidacion.IsValid)
            {
                if (NuevoRegistro) //nuevo registro
                {
                    if (usuarios.GuardarNuevoUsuario())
                    {
                        RJMessageBox.Show("Usuario añadido con exito");
                        LimpiarForm();
                    }
                    else RJMessageBox.Show("El Nombre de Usuario ya esta en uso", "Errores en Usuarios", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_nombreUsuario.Focus();
                    
                }
                else //editar un registro
                {
                    if (usuarios.EditarUsuario())
                    {
                        RJMessageBox.Show("Usuario modificado con exito");
                        btn_cancelar.PerformClick();
                    }else RJMessageBox.Show("El Nombre de Usuario ya esta en uso", "Errores en Usuarios", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_nombreUsuario.Focus();
                    
                }                
            }
            else
            {
                RJMessageBox.Show(ListarErrores(resultadosValidacion), "Errores en Login", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void LimpiarForm()
        {
            txt_id.Texts = string.Empty;
            txt_contraseña.Texts = string.Empty;
            txt_nombreUsuario.Texts = string.Empty;
            cbo_empleado.SelectedIndex = -1;
            cbo_rol.SelectedIndex = -1;
            txt_nombreUsuario.Focus();
        }

        private string ListarErrores(FluentValidation.Results.ValidationResult resultados)
        {
            string listaErrores = "Se encontraron los siguientes errores:";

            foreach (var error in resultados.Errors)
            {
                listaErrores += ("\n - " + error.ErrorMessage);
            }

            return listaErrores;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frm = Application.OpenForms.OfType<Form_MenuPrincipal>().SingleOrDefault();
            frm.AbrirFormulario(new Form_GeneralUsuarios());
        }
    }
}

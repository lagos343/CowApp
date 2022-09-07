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
            Form_MenuPrincipal frm = Application.OpenForms.OfType<Form_MenuPrincipal>().SingleOrDefault();
            frm.AbrirFormulario(new Form_GeneralUsuarios());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frm = Application.OpenForms.OfType<Form_MenuPrincipal>().SingleOrDefault();
            frm.AbrirFormulario(new Form_GeneralUsuarios());
        }
    }
}

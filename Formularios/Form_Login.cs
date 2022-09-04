using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominioNegocio;
using CapaDominioNegocio.Validaciones;
using CapaPresentacion.RjMessageBox;


namespace CapaPresentacion
{
    public partial class Form_Login : Form
    {
        CnUsuarioLogueado login = new CnUsuarioLogueado();

        public Form_Login()
        {
            InitializeComponent();

            //Border Appareance
            Color borderColor = Color.FromArgb(129, 173, 248);
            int borderSize = 1;

            this.BackColor = borderColor;
            this.Padding = new Padding(borderSize);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tgbtn_ver_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbtn_ver_contraseña.Checked) txt_contraseña.PasswordChar = false;
            else txt_contraseña.PasswordChar = true;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //instancia de las clases de validacion
            var validadorLogin = new CnUsuarioLogueadoValidator();

            //mandamos los datos a la clase
            login.NombreUsuario = txt_usuario.Texts;
            login.ContraUsuario = txt_contraseña.Texts;

            //extraemos el resultado de la validacion de la clase
            var resultadosValidacion = validadorLogin.Validate(login);

            if (resultadosValidacion.IsValid)
            {
                if (login.PermitirLogueo()) RJMessageBox.Show("Bienvenido al sistema");
                else
                {
                    RJMessageBox.Show("¡Credenciales incorrectas!\nCorrija el nombre de usuario o la contraseña\npor datos validos",
                    "Errores en Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_contraseña.Texts = string.Empty;
                    txt_usuario.Focus();
                }
            }
            else
            {
                RJMessageBox.Show(ListarErrores(resultadosValidacion), "Errores en Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contraseña.Texts = string.Empty;
                txt_usuario.Focus();
            }
        }

        //Prod para extraer la lista de errores
        private string ListarErrores(FluentValidation.Results.ValidationResult resultados)
        {
            string listaErrores = "Se encontraron los siguientes errores:";

            foreach (var error in resultados.Errors)
            {
                listaErrores += ("\n - " + error.ErrorMessage);
            }

            return listaErrores;
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Texts == "Usuario") txt_usuario.Texts = string.Empty;
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Texts == "Contraseña") txt_contraseña.Texts = string.Empty;
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            var rjText = (RJCodeAdvance.RJControls.RJTextBox)sender;

            if (rjText.Texts == string.Empty) 
            {
                if (rjText.Name == "txt_usuario") rjText.Texts = "Usuario";
                else rjText.Texts = "Contraseña";
            } 
        }
    }
}

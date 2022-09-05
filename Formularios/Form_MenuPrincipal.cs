using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.RjMessageBox;

namespace CapaPresentacion.Formularios
{
    public partial class Form_MenuPrincipal : Form
    {
        private Form formActivado = null;

        #region Movimiento del formulario  

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        public Form_MenuPrincipal()
        {
            InitializeComponent();

            //Border Appareance
            Color borderColor = Color.FromArgb(255, 142, 0);
            int borderSize = 1;

            this.BackColor = borderColor;
            this.Padding = new Padding(borderSize);
            panel1.BackColor = Color.White;
            iconButton5.BackColor = Color.White;
        }

        #region Bonones Generales del Formulario

        private void btn_salir_MouseHover(object sender, EventArgs e)
        {
            btn_salir.BackColor = Color.FromArgb(244, 98, 101);
        }        

        private void btn_salir_MouseLeave(object sender, EventArgs e)
        {
            var btn = (FontAwesome.Sharp.IconPictureBox)sender;
            btn.BackColor = Color.FromArgb(255, 142, 0);            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            var cerrar = RJMessageBox.Show("¿Esta seguro que quiere cerrar la Aplicacion?", "CowApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cerrar == DialogResult.Yes) Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Botones del Menu

        public void AbrirFormulario(Form formHijo) //abre los formularios hijos en el panel 
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            panel_contenedorForms.Controls.Add(formHijo);
            formHijo.BringToFront();
            formHijo.Show();
        }

        public void SelecionarBoton(FontAwesome.Sharp.IconButton btn)
        {
            //lista de los botones del menu
            FontAwesome.Sharp.IconButton[] botones;
            botones = new FontAwesome.Sharp.IconButton[] { btn_usuarios};

            foreach (var boton in botones)
            {
                boton.BackColor = Color.FromArgb(29, 29, 46);
                boton.ForeColor = Color.FromArgb(147, 149, 170);
                boton.IconColor = Color.FromArgb(147, 149, 170);
            }

            btn.BackColor = Color.FromArgb(213, 109, 255);
            btn.ForeColor = Color.White;
            btn.IconColor = Color.White;
            iconButton5.Text = btn.Text;
            iconButton5.IconChar = btn.IconChar;
        }

        #endregion

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            SelecionarBoton((FontAwesome.Sharp.IconButton)sender);
            AbrirFormulario(new Form_GeneralUsuarios());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SelecionarBoton((FontAwesome.Sharp.IconButton)sender);
        }
    }
}

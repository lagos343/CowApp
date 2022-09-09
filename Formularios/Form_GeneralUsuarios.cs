﻿using System;
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
    public partial class Form_GeneralUsuarios : Form
    {
        CnUsuarios usuarios = new CnUsuarios();

        public Form_GeneralUsuarios()
        {
            InitializeComponent();
        }

        private void Form_GeneralUsuarios_Load(object sender, EventArgs e)
        {
            CargarListaRegistros();
        }

        private void CargarListaRegistros()
        {
            dgv_usuarios.DataSource = usuarios.ObtenerListaUsuarios();

            foreach (DataGridViewColumn columna in dgv_usuarios.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgv_usuarios.Columns[0].Visible = false;
        }        

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frm = Application.OpenForms.OfType<Form_MenuPrincipal>().SingleOrDefault();
            frm.AbrirFormulario(new Form_MantenimientoUsuarios(true));
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frm = Application.OpenForms.OfType<Form_MenuPrincipal>().SingleOrDefault();
            frm.AbrirFormulario(new Form_MantenimientoUsuarios(false, dgv_usuarios.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            var resultado = RJMessageBox.Show("¿Esta seguro que desea eliminar este Usuario?", "CowApp Usuarios", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                usuarios.IdUsuario = dgv_usuarios.CurrentRow.Cells[0].Value.ToString();
                usuarios.EliminarUsuario();
                RJMessageBox.Show("Usuario eliminado con Exito");
                btn_buscar.PerformClick();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            usuarios.NombreUsuario = txt_busquedaFiltrada.Texts;
            dgv_usuarios.DataSource = usuarios.ObtenerUsuarioMedianteBusqueda();
        }

        private void txt_busquedaFiltrada__TextChanged(object sender, EventArgs e)
        {
            btn_buscar.PerformClick();
        }
    }
}

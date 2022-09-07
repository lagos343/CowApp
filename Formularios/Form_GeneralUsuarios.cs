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
    }
}

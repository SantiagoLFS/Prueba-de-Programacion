using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUsuario
{
    public partial class Menu : Form
    {
        UsuarioBL _usuariosBL;

        public Menu()
        {
            InitializeComponent();

            _usuariosBL = new UsuarioBL();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var login = new Form1();
            login.CargarDatos(_usuariosBL);
            login.ShowDialog();

            productosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProductos;
            facturaToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerFacturas;
            productosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProductos;
            reporteDeProductosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReportesdeProductos;
            reporteDeVentasToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReportesdeVentas;
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        UsuarioBL _usuariosBL;

        public Usuario UsuarioAutenticado { get; set; }

        public Form1()
        {
            InitializeComponent();

                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var nombre = textBox1.Text;
            var contrasena = textBox2.Text;

            var usuarioAutenticado = _usuariosBL.Autenticar(nombre, contrasena);

            if (usuarioAutenticado != null)
            {
                UsuarioAutenticado = usuarioAutenticado;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contrasena erronea");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CargarDatos(UsuarioBL usuarioBL)
        {
            _usuariosBL = usuarioBL;
        }
    }
}

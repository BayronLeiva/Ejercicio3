using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Conexion.Clases;
using Conexion.Entidades;

namespace Ejercicio3
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioAcceso usuarioAcceso = new UsuarioAcceso();
            Usuario usuario = new Usuario();

            usuario = usuarioAcceso.Login(Convert.ToInt32(textBoxNumeroCuenta.Text), textBoxContraseña.Text);

            if(usuario == null)
            {
                MessageBox.Show("El usuario no existe");
                return;
            }

            FrmRegistrados frmRegistrados = new FrmRegistrados();
            frmRegistrados.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

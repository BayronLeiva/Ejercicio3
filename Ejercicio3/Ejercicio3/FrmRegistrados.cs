using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion.Clases;
using Conexion.Entidades;

namespace Ejercicio3
{
    public partial class FrmRegistrados : Form
    {
        public FrmRegistrados()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();
        UsuarioAcceso usuarioAcceso = new UsuarioAcceso();

        private void FrmRegistrados_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            ListadataGridView.DataSource = usuarioAcceso.MostrarUsuarios();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokyoStock.Core.Business;
using TokyoStock.Core.Data;

namespace TokyoStock.App
{
    public partial class InitForm : Form
    {
        private static UsuarioRepository usuarioRepository = new UsuarioRepository();
        private static UsuarioBusiness usuarioBusiness = new UsuarioBusiness(usuarioRepository);
        public InitForm()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            var usuario = tbUsuarioIngreso.Text;
            var pass = tbContraIngreso.Text;

            if (usuarioBusiness.ValidarUsuario(usuario, pass))
            {
                HomeForm1._isLogged = true;
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }
        private void btRegistrar_Click(object sender, EventArgs e)
        {
            var usuario = tbUsuarioRegistro.Text;
            var pass = tbContraRegistro.Text;
            usuarioBusiness.RegistrarUsuario(usuario, pass);
            MessageBox.Show("Usuario registrado correctamente");
            tbContraIngreso.Text = "Contraseña";
            tbUsuarioIngreso.Text = "Usuario";
        }

        private void tbUsuarioIngreso_Enter(object sender, EventArgs e)
        {
            if (tbUsuarioIngreso.Text == "Usuario")
            {
                tbUsuarioIngreso.Text = "";
                tbUsuarioIngreso.ForeColor = SystemColors.ControlText;
            }
        }

        private void tbUsuarioIngreso_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsuarioIngreso.Text))
            {
                tbUsuarioIngreso.Text = "Usuario";
                tbUsuarioIngreso.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbContraIngreso_Enter(object sender, EventArgs e)
        {
            if (tbContraIngreso.Text == "Contraseña")
            {
                tbContraIngreso.Text = "";
                tbContraIngreso.ForeColor = SystemColors.ControlText;
            }
        }
        private void tbContraIngreso_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbContraIngreso.Text))
            {
                tbContraIngreso.Text = "Contraseña";
                tbContraIngreso.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbUsuarioRegistro_Enter(object sender, EventArgs e)
        {
            if (tbUsuarioRegistro.Text == "Usuario")
            {
                tbUsuarioRegistro.Text = "";
                tbUsuarioRegistro.ForeColor = SystemColors.ControlText;
            }
        }

        private void tbUsuarioRegistro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsuarioRegistro.Text))
            {
                tbUsuarioRegistro.Text = "Usuario";
                tbUsuarioRegistro.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbContraRegistro_Enter(object sender, EventArgs e)
        {
            if (tbContraRegistro.Text == "Contraseña")
            {
                tbContraRegistro.Text = "";
                tbContraRegistro.ForeColor = SystemColors.ControlText;
            }
        }

        private void tbContraRegistro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbContraRegistro.Text))
            {
                tbContraRegistro.Text = "Contraseña";
                tbContraRegistro.ForeColor = SystemColors.GrayText;
            }
        }

    }
}

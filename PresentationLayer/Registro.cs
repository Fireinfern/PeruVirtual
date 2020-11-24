using Datos;
using MySql.Data.MySqlClient;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Registro : Form
    {
        private UsuarioService usuarioService = new UsuarioService();

        public Registro()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (tb_nombre_de_usuario.Text.Length == 0) { lbl_error_nombreusuario.Visible = true; }
            if (tb_nombre_completo.Text.Length == 0) { lbl_error_nombrecompleto.Visible = true; }
            if (tb_email.Text.Length == 0) { lbl_error_email.Visible = true; }
            if (tb_contraseña.Text.Length == 0) { lbl_error_contrasena.Visible = true; }
            if (tb_confimar_contraseña.Text.Length == 0) { lbl_error_confirmarcontra.Visible = true; }

            if (lbl_error_confirmarcontra.Visible || lbl_error_contrasena.Visible || lbl_error_email.Visible ||
                lbl_error_nombreusuario.Visible || lbl_error_nombrecompleto.Visible)
            {
                return;
            }

            if (tb_contraseña.Text != tb_confimar_contraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            usuario user = new usuario();
            user.nombre = tb_nombre_completo.Text;
            user.username = tb_nombre_de_usuario.Text;
            user.correo = tb_email.Text;
            user.contrasena = tb_contraseña.Text;

            var confirmacion = usuarioService.Registro(user);
            if(confirmacion)
            {
                MessageBox.Show("Registro Completo");
                this.Close();            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_nombre_de_usuario_TextChanged(object sender, EventArgs e)
        {
            lbl_error_nombreusuario.Visible = false;
        }

        private void tb_nombre_completo_TextChanged(object sender, EventArgs e)
        {
            lbl_error_nombrecompleto.Visible = false;
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            lbl_error_email.Visible = false;
        }

        private void tb_contraseña_TextChanged(object sender, EventArgs e)
        {
            lbl_error_contrasena.Visible = false;
        }
        private void tb_confimar_contraseña_TextChanged(object sender, EventArgs e)
        {
            lbl_error_confirmarcontra.Visible = false;
        }
    }
}

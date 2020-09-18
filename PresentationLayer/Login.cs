using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuUserControl.Transitions;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        //Inicializacionde Capa ModeloNegocio
        private ModeloNegocio.Cliente cliente = new ModeloNegocio.Cliente();
        private ModeloNegocio.Usuario usuario = new ModeloNegocio.Usuario();
        //Inicializacion de Servicios
        private Servicios.ClienteService clienteService = new Servicios.ClienteService();
        private Servicios.UsuarioService usuarioService = new Servicios.UsuarioService();
        private Servicios.Facebooklogin facebookLogin = new Servicios.Facebooklogin();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro que deseas Salir?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
                Application.Exit();
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TitleLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.usuarioService.AccesClient(UsernameTxt.Text, PasswordTxt.Text));
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void RegistroLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPanel.Dock = DockStyle.None;
            LoginPanel.Visible = false;
            RegistroPanel.Dock = DockStyle.Fill;
            RegistroPanel.Visible = true;
            WindowNameLbl.Text = "PeruVirtual - Registro";
        }

        private void CancelRegBtn_Click(object sender, EventArgs e)
        {
            RegEmailTxt.Text = "";
            RegContraseniaTxt.Text = "";
            RegConfTxt.Text = "";
            RegUsernameTxt.Text = "";
            RegNombreTxt.Text = "";
            ErrorRegLbl.Text = "";
            RegistroPanel.Dock = DockStyle.None;
            RegistroPanel.Visible = false;
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Visible = true;
            WindowNameLbl.Text = "PeruVirtual - Login";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool Valido = true;
            if (this.cliente.IsEmailTaken(RegEmailTxt.Text))
            {
                Valido = false;
                ErrorRegLbl.Text = "Correo electronico no disponible";
            }
            if (this.usuario.IsUsernameTaken(RegUsernameTxt.Text))
            {
                Valido = false;
                ErrorRegLbl.Text = "Nombre de usuario no disponible";
            }
            if (RegContraseniaTxt.Text != RegConfTxt.Text)
            {
                Valido = false;
                ErrorRegLbl.Text = "Las contraseñas deben coincidir";
            }
            if (!TerminosCondicionesCbx.Checked)
            {
                Valido = false;
                ErrorRegLbl.Text = "Debe aceptar los terminos y condiciones para continuar";
            }
            if (RegEmailTxt.Text == "" ||
            RegContraseniaTxt.Text == "" ||
            RegConfTxt.Text == ""||
            RegUsernameTxt.Text == ""||
            RegNombreTxt.Text == "")
            {
                Valido = false;
                ErrorRegLbl.Text = "Ningun Campo puede estar vacio";
            }
            if(Valido)
            {
                this.clienteService.CreateClient(RegEmailTxt.Text, RegContraseniaTxt.Text, RegUsernameTxt.Text, RegNombreTxt.Text);
                RegEmailTxt.Text = "";
                RegContraseniaTxt.Text = "";
                RegConfTxt.Text = "";
                RegUsernameTxt.Text = "";
                RegNombreTxt.Text = "";
                RegistroPanel.Dock = DockStyle.None;
                RegistroPanel.Visible = false;
                LoginPanel.Dock = DockStyle.Fill;
                LoginPanel.Visible = true;
            }
        }

        private void FacebookLogin_Click(object sender, EventArgs e)
        {
            facebookLogin.getCode();
        }
    }
}

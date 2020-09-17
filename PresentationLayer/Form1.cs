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
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
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
            Console.WriteLine(Servicios.UsuarioService.AccesClient(UsernameTxt.Text, PasswordTxt.Text));
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
            WindowNameLbl.Text = "PeruVirtual - Registro";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool Valido = true;
            if (ModeloNegocio.Cliente.IsEmailTaken(RegEmailTxt.Text))
            {
                Valido = false;
                ErrorRegLbl.Text = "Correo electronico no disponible";
            }
            if (ModeloNegocio.Usuario.IsUsernameTaken(RegUsernameTxt.Text))
            {
                Valido = false;
                ErrorRegLbl.Text = "Nombre de usuario no disponible";
            }
            if (RegContraseniaTxt.Text != RegConfTxt.Text)
            {
                Valido = false;
                ErrorRegLbl.Text = "Las contraseñas deben coincidir";
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
                //Servicios.ClienteService.CreateClient(RegEmailTxt.Text, RegContraseniaTxt.Text, RegUsernameTxt.Text, RegNombreTxt.Text);
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
    }
}

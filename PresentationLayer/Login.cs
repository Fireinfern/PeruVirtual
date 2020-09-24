using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        //VO
        private VO.Code code = new VO.Code();
        private VO.Autho autho = new VO.Autho();
        private VO.FacebookUser facebookUser = new VO.FacebookUser();
        public VO.Session session;
        
        //private Bitmap bg = new Bitmap("./Assets/BG_slide.jpg"); 

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Login()
        {
            InitializeComponent();
        }
        
        private void openMainForm(object form)
        {
            this.BackgroundImage = Properties.Resources.BG_slide;
            LoginPanel.Visible = false;
            ConfirmationPanel.Visible = false;
            MainContainer.Visible = true;
            MainContainer.Dock = DockStyle.Fill;
            if (this.MainContainer.Controls.Count > 0)
            {
                this.MainContainer.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainContainer.Controls.Add(f);
            this.MainContainer.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginPanel.Dock = DockStyle.Fill;
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
            var clienteSession=this.clienteService.getClient(this.usuarioService.AccesClient(UsernameTxt.Text, PasswordTxt.Text));
            if(clienteSession != null)
            {
                session = new VO.Session(clienteSession.nombre, clienteSession.correo);
                //MessageBox.Show("Bienvenido " + session.Nombre, "Bienvenido", MessageBoxButtons.OK);
                openMainForm(new Aplication());
            }
            else
            {
                MessageBox.Show("usuario o contraseña erroneos","Error" ,MessageBoxButtons.OK);
            }
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

        private async void FacebookLogin_Click(object sender, EventArgs e)
        {
            this.code =await facebookLogin.getCode();
            //Console.WriteLine(this.code.user_code);
            //MessageBox.Show("Su codigo de confirmacion es " + this.code.user_code + " visite " + this.code.verification_uri, "Verifique su cuenta de Facebook", MessageBoxButtons.OK);
            LoginPanel.Visible = false;
            LoginPanel.Dock = DockStyle.None;
            Login.ActiveForm.Height = 600;
            ConfirmationPanel.Visible = true;
            ConfirmationPanel.Dock = DockStyle.Fill;
            FacebookBrowser.Height = 550;
            //Console.WriteLine(this.code.verification_uri.GetType() + " " + this.code.verification_uri.ToString());
            CodigoLbl.Text = "Tu Codigo: " + this.code.user_code;
            FacebookBrowser.Navigate(this.code.verification_uri.ToString());
            timer1.Enabled = true;
        }

        private void CancelFacebookBtn_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Height = 450;
            ConfirmationPanel.Dock = DockStyle.None;
            ConfirmationPanel.Visible = false;
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Visible = true;
            WindowNameLbl.Text = "PeruVirtual - Login";
        }

        private void FacebookBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            this.autho = await facebookLogin.getAuth(this.code.code);
            //Console.WriteLine(autho.access_token);
            if(autho.access_token != null)
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.facebookUser=await facebookLogin.getUser(autho.access_token);
                session = new VO.Session(facebookUser.name, facebookUser.email);
                Console.WriteLine(session.Nombre + " " + session.Email);
                openMainForm(new Aplication());
            }
        }
    }
}

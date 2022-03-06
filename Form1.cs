using System.Runtime.InteropServices;
namespace Ferreteria_Garabito_Pichardo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cerrar_ventana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_ventana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar_ventana.Visible = false;
            Restaurar_ventana.Visible = true;

        }

        private void Restaurar_ventana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar_ventana.Visible = false;
            Maximizar_ventana.Visible = true;
        }

        private void Minimizar_ventana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_imagen_Click(object sender, EventArgs e)
        {

        }

        private void Boton_entrar_Click(object sender, EventArgs e)
        {

        }

        private void Panel_center_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Barra_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_imagen_Click_1(object sender, EventArgs e)
        {

        }
    }
}
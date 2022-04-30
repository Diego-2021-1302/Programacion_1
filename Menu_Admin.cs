using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Ferreteria_Garabito_Pichardo
{
    public partial class Menu_Admin : Form
    {
        public Menu_Admin(string nombre)
        {
            InitializeComponent();
            Lbl_Administrador.Text = nombre;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Boton_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Boton_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Boton_Maximizar.Visible = false;
            Boton_Restaurar.Visible = true;
        }

        private void Boton_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Boton_Restaurar.Visible = false;
            Boton_Maximizar.Visible = true;
        }

        private void Boton_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Abrir_Formularios_panel(object Formhijo)
        {
            if (this.Panel_Central.Controls.Count > 0)
                this.Panel_Central.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Central.Controls.Add(fh);
            this.Panel_Central.Tag = fh;
            fh.Show();
        }

        private void Panel_Central_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Boton_Producto_Click(object sender, EventArgs e)
        {

            Abrir_Formularios_panel(new Productos_Form());
        }
        
    }
}

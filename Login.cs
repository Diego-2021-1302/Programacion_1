using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Ferreteria_Garabito_Pichardo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        //Biblioteca para mover el Formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Conexion de la base de datos del LOGIN
        readonly SqlConnection connection = new SqlConnection("server=Diego-Garabito ; database = FGP ; INTEGRATED SECURITY = TRUE");
        private void Form_Login(string usuario, string Contraseña)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nom_Usuario, Tipo_Usuario FROM Usuarios WHERE Nom_Usuario = @vusuario AND Contraseña = @vcontraseña", connection);
                cmd.Parameters.AddWithValue("@vusuario", usuario);
                cmd.Parameters.AddWithValue("@vcontraseña", Contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count == 1){

                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador"){ 
                        new Menu_Admin(dt.Rows[0][0].ToString()).Show();
             
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")

                    {
                        new Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        // Funciones del Formulario
        private void Boton_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Boton_Maximizar.Visible = false;
            Boton_Restaurar.Visible = true;
        }

        private void Boton_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Boton_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Boton_Restaurar.Visible = false;
            Boton_Maximizar.Visible = true;
        }

        private void Boton_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Boton_Inicio_Click(object sender, EventArgs e)
        {
            Form_Login(this.Texbox_Usuario.Text, this.Texbox_Contraseña.Text);
        }

        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Barra_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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

namespace Ferreteria_Garabito_Pichardo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("server=UNICOMICOPTERO- ; database = FGP ; INTEGRATED SECURITY = TRUE");

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
                        new Admin(dt.Rows[0][0].ToString()).Show();
             
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Login(this.textBox1.Text, this.textBox2.Text);
        }

        private void Boton_Productos_Click(object sender, EventArgs e)
        {

        }

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
    }
}

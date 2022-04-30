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
using Ferreteria_Garabito_Pichardo.SQL_Server;
using Ferreteria_Garabito_Pichardo.Modelos;

namespace Ferreteria_Garabito_Pichardo
{
    public partial class Productos_Form : Form
    {
        public Productos_Form()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Boton_Guardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un producto valido");
            } else if (txtCodigo.Text.Trim().Length < 1)
            {
                MessageBox.Show("Debe ingresar un nombre mas largo");

            }
            else
            {
                try
                {
                    Productos em = new Productos
                    {
                        Codigo1 = Convert.ToInt32(txtCodigo.Text.Trim()),
                        Nombre1 = txtNombre.Text.Trim(),
                        Detalles1 = txtDetalles.Text.Trim(),
                        Marca1 = txtMarca.Text.Trim(),
                        Cantidad1 = txtCantidad.Text.Trim(),
                        Precio1 = txtPrecio.Text.Trim()
                    };

                    if (ProductosCAD.Guardar(em))
                    {
                        LlenarGrid();
                        LimpiarCampos();


                        MessageBox.Show("Producto guardado correctamente");

                    }
                    else
                    {
                        MessageBox.Show("Ya existe este producto");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }
        private void LlenarGrid()
        {
            DataTable datos = ProductosCAD.Listado();
            if (datos == null)
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }
            else
            {
                DgVista.DataSource = datos.DefaultView;
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDetalles.Text = "";
            txtMarca.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        private void Productos_Form_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void Boton_Consulta_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un producto");
            }
            else
            {
                Productos em = ProductosCAD.Consultar(txtCodigo.Text.Trim());
                if (em == null)     
                {
                    MessageBox.Show("No existe el empleado"   +  txtCodigo.Text);


                }
                else
                {
                    txtCodigo.Text = em.Codigo1.ToString();
                    txtNombre.Text = em.Nombre1;
                    txtDetalles.Text = em.Detalles1;
                    txtMarca.Text = em.Marca1;
                    txtCantidad.Text = em.Cantidad1;
                    txtPrecio.Text = em.Precio1;
                }
            
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_Garabito_Pichardo
{
    public partial class Usuario : Form
    {
        public Usuario(string nombre)
        {
            InitializeComponent();
            Lbl_mensaje_User.Text  = nombre;
        }

        private void Lbltipo_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void Letra_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}

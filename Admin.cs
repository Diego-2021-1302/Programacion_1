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
    public partial class Admin : Form
    {
        public Admin(string nombre)
        {
            InitializeComponent();
            Lbl_Mensaje_Admin.Text = nombre;
        }
    }
}

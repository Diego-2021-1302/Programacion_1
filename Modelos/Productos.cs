using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Garabito_Pichardo.Modelos
{
    class Productos
    {
        private int Codigo;
        private string Nombre;
        private string Detalles;
        private string Marca;
        private string Cantidad;
        private string Precio;
         
        public Productos()
        {
            this.Codigo = 0;
            this.Nombre = "";
            this.Detalles = "";
            this.Marca = "";
            this.Cantidad = "";
            this.Precio = "";


        }



        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Detalles1 { get => Detalles; set => Detalles = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string Precio1 { get => Precio; set => Precio = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ferreteria_Garabito_Pichardo.SQL_Server
{
    class Conexion
    {
        readonly SqlConnection conexion;
        public Conexion()
        {
            conexion = new SqlConnection("Server=Diego-Garabito;Database=FGP;integrated security=true");
        }
        public SqlConnection Conectar()
        {
            try
            {
                conexion.Open(); 
                return conexion;
            }
            catch (Exception)
            {
                return null;

            }
        }
        public bool Desconectar()
        {
            try
            {
                conexion.Close();
                return true;
            }   
            catch (Exception)
            {
                return false;

            }
        }
    }
}   

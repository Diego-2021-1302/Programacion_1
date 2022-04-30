using Ferreteria_Garabito_Pichardo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ferreteria_Garabito_Pichardo.SQL_Server
{
    class ProductosCAD

    {
        public static bool Guardar(Productos e)
        { 

            try
            {
                Conexion conexion = new Conexion();
                string sql = "Insert into Productos values('" + e.Codigo1+ "','" + e.Nombre1+ "','" + e.Detalles1+ "','" + e.Marca1+ "','" + e.Cantidad1+ "','" + e.Precio1+ "')";
                SqlCommand comando = new SqlCommand(sql,conexion.Conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    conexion.Desconectar();
                    return true;
                }
                else return false;


            }
            catch (Exception)
            {

                return false;
            }
        }



        public static DataTable Listado()
        {

            try
            {
                Conexion conexion = new Conexion();
                string sql = "Select * From Productos;";
                SqlCommand comando = new SqlCommand(sql, conexion.Conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable(); 
                dt.Load(dr);
                
                conexion.Desconectar();
                
                return dt;
                
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static Productos Consultar(string Codigo)
        {

            try
            {
                Conexion conexion = new Conexion();
                string sql = "Select * From Productos Where Codigo = '"+Codigo+"';";
                SqlCommand comando = new SqlCommand(sql, conexion.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                Productos em = new Productos();
                if (dr.Read())
                {
                    em.Codigo1 = Convert.ToInt32(dr ["Codigo"].ToString());
                    em.Nombre1 = dr["Nombre"].ToString();
                    em.Detalles1 = dr["Detalles"].ToString();
                    em.Marca1 = dr["Marca"].ToString();
                    em.Cantidad1 = dr["Cantidad"].ToString();
                    em.Precio1 = dr["Precio"].ToString();
                    return em;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {

                return null;
            }
        }
    }

}

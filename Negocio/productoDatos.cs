using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Dominio
{
    public class productoDatos
    {
        public List<Producto> listaGeneral()
        {
            List<Producto> listaGeneral = new List<Producto>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.Precio, ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C where IdMarca = M.Id and IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Producto aux = new Producto();
                    aux.nombre = lector.GetString(0) ;
                    aux.descripcion = lector.GetString(1);
                    aux.marca = lector.GetString(2);
                    aux.categoria = lector.GetString(3);
                    aux.precio = lector.GetDecimal(4);
                    aux.imagen = lector.GetString(5);
                              
                    listaGeneral.Add(aux);
                }
                
                conexion.Close();     
                return listaGeneral;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
         
    
    }
}

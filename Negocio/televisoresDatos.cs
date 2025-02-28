using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dominio
{
    public class televisoresDatos
    {
        public List<Televisor> listaTelevisores()
        {
            List<Televisor> listaTelevisores = new List<Televisor>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Nombre, M.Descripcion Marca, A.Descripcion, A.Precio, ImagenUrl from ARTICULOS A, MARCAS M where IdCategoria = 2 and IdMarca = M.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Televisor aux = new Televisor();
                    aux.nombre = lector.GetString(0);
                    aux.marca = lector.GetString(1); 
                    aux.descripcion = lector.GetString(2);  
                    aux.precio = lector.GetDecimal(3);
                    aux.imagen = lector.GetString(4); 
                    

                    listaTelevisores.Add(aux);

                }
                conexion.Close();
                return listaTelevisores;            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Presentacion
{
    internal class mediaDatos
    {
        public List<Media> listaMedia()
        {
			List<Media> listaMedia = new List<Media>();
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			
			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select A.Nombre, M.Descripcion Marca, A.Descripcion, A.Precio, ImagenUrl from ARTICULOS A, MARCAS M where IdCategoria = 3 and IdMarca = M.Id";
				comando.Connection = conexion;

				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read()) 
				{
					Media aux = new Media();
					aux.nombre = lector.GetString(0);
					aux.marca = lector.GetString(1);
					aux.descripcion = lector.GetString(2);
					aux.precio = lector.GetDecimal(3);
					aux.imagen = lector.GetString(4);
					
					listaMedia.Add(aux);	

				}
				conexion.Close();
                return listaMedia;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}

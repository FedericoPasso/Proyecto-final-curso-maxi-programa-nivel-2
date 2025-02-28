using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        //public int idArticulo { get; set; }

        public string categoria { get; set; }
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string marca { get; set; }

        public decimal precio { get; set; }

        public string imagen { get; set; }
    }
}

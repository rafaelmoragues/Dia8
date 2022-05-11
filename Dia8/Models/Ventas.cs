using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8.Models
{
    public class Venta
    {
        public Venta()
        {
            
        }

        public int Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public int NroRemito { get; set; }
        
    }
}

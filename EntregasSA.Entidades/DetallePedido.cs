using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregasSA.Entidades
{
    public class DetallePedido 
    {
        public int NumeroPedido { get; set; } 
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public double Monto { get; set; }
    }
}

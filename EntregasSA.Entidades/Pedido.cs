using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregasSA.Entidades
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public Cliente cliente { get; set; }
        public Repartidor repartidor { get; set; }
        public string Direccion { get; set; }
    }
}

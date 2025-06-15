using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregasSA.Entidades
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoArticulo TipoArticulo { get; set; }
        public double Valor { get; set; }
        public int Inventario { get; set; }
        public bool Activo { get; set; }

    }
}

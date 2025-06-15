using EntregasSA.Entidades;
using System;
using System.Linq;

namespace EntregasSA.AccesoDatos
{
    public class DatosDetallePedido
    {
        private static DetallePedido[] detallesPedido = new DetallePedido[500];  // Arreglo de 500 posiciones
        private static int contador = 0;

        public static void AgregarDetalle(DetallePedido detalle)
        {
            // Validar que no exista el mismo artículo en el mismo pedido
            if (Array.Exists(detallesPedido, d => d != null && 
                d.NumeroPedido == detalle.NumeroPedido && 
                d.Articulo.Id == detalle.Articulo.Id))
            {
                throw new Exception("Este artículo ya está registrado en el pedido.");
            }

            if (contador >= 500)
                throw new Exception("No se pueden agregar más detalles de pedido.");

            detallesPedido[contador++] = detalle;
        }

        public static DetallePedido[] ObtenerDetallesPorPedido(int numeroPedido)
        {
            return detallesPedido.Where(d => d != null && d.NumeroPedido == numeroPedido).ToArray();
        }

        public static DetallePedido[] ObtenerDetalles()
        {
            return detallesPedido.Where(d => d != null).ToArray();
        }
    }
}
using EntregasSA.AccesoDatos;
using EntregasSA.Entidades;
using System;
using System.Linq;

namespace EntregasSA.LogicaNegocio
{
    public class LogicaPedido
    {
        private const double PORCENTAJE_ENVIO = 0.12;

        public static void GuardarPedido(string numeroPedidoStr, DateTime fechaPedido,
            Cliente cliente, Repartidor repartidor, string direccion)
        {
            ValidarEncabezadoPedido(numeroPedidoStr, fechaPedido, cliente, repartidor, direccion, 
                                  out int numeroPedido);

            var pedido = new Pedido
            {
                NumeroPedido = numeroPedido,
                FechaPedido = fechaPedido,
                cliente = cliente,
                repartidor = repartidor,
                Direccion = direccion
            };

            DatosPedido.AgregarPedido(pedido);
        }

        public static void AgregarDetallePedido(int numeroPedido, Articulo articulo, int cantidad)
        {
            ValidarDetallePedido(numeroPedido, articulo, cantidad);

            var detalle = new DetallePedido
            {
                NumeroPedido = numeroPedido,
                Articulo = articulo,
                Cantidad = cantidad,
                Monto = CalcularMontoConEnvio(articulo.Valor, cantidad)
            };

            ActualizarInventarioArticulo(articulo, cantidad);
            DatosDetallePedido.AgregarDetalle(detalle);
        }

        private static void ValidarEncabezadoPedido(string numeroPedidoStr, DateTime fechaPedido,
            Cliente cliente, Repartidor repartidor, string direccion, out int numeroPedido)
        {
            if (!int.TryParse(numeroPedidoStr, out numeroPedido))
                throw new ArgumentException("El número de pedido debe ser un número válido.");

            if (numeroPedido <= 0)
                throw new ArgumentException("El número de pedido debe ser mayor que cero.");

            if (fechaPedido.Date < DateTime.Today)
                throw new ArgumentException("La fecha del pedido no puede ser anterior a hoy.");

            if (cliente == null)
                throw new ArgumentException("Debe seleccionar un cliente.");

            if (!cliente.Activo)
                throw new ArgumentException("El cliente seleccionado no está activo.");

            if (repartidor == null)
                throw new ArgumentException("Debe seleccionar un repartidor.");

            if (!repartidor.Activo)
                throw new ArgumentException("El repartidor seleccionado no está activo.");

            if (string.IsNullOrWhiteSpace(direccion))
                throw new ArgumentException("La dirección es obligatoria.");

            if (ExistePedido(numeroPedido))
                throw new ArgumentException("Ya existe un pedido con ese número.");
        }

        private static void ValidarDetallePedido(int numeroPedido, Articulo articulo, int cantidad)
        {
            if (articulo == null)
                throw new ArgumentException("Debe seleccionar un artículo.");

            if (!articulo.Activo)
                throw new ArgumentException("El artículo seleccionado no está activo.");

            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.");

            if (cantidad > articulo.Inventario)
                throw new ArgumentException($"No hay suficiente inventario. Disponible: {articulo.Inventario}");

            var detalles = DatosDetallePedido.ObtenerDetallesPorPedido(numeroPedido);
            if (detalles.Any(d => d.Articulo.Id == articulo.Id))
                throw new ArgumentException("Este artículo ya está registrado en el pedido.");
        }

        private static void ActualizarInventarioArticulo(Articulo articulo, int cantidad)
        {
            if (articulo.Inventario < cantidad)
                throw new ArgumentException($"No hay suficiente inventario. Disponible: {articulo.Inventario}");

            articulo.Inventario -= cantidad;
            if (articulo.Inventario == 0)
                articulo.Activo = false;
        }

        public static double CalcularMontoConEnvio(double valorUnitario, int cantidad)
        {
            double subtotal = valorUnitario * cantidad;
            return subtotal + (subtotal * PORCENTAJE_ENVIO);
        }

        public static bool ExistePedido(int numeroPedido)
        {
            var pedidos = DatosPedido.ObtenerPedidos();
            return pedidos.Any(p => p.NumeroPedido == numeroPedido);
        }

        public static Pedido[] ObtenerPedidos()
        {
            return DatosPedido.ObtenerPedidos();
        }

        public static DetallePedido[] ObtenerDetallesPedido(int numeroPedido)
        {
            return DatosDetallePedido.ObtenerDetallesPorPedido(numeroPedido);
        }

        public static Cliente[] ObtenerClientesActivos()
        {
            return LogicaCliente.ObtenerClientes().Where(c => c.Activo).ToArray();
        }

        public static Repartidor[] ObtenerRepartidoresActivos()
        {
            return LogicaRepartidor.ObtenerRepartidores().Where(r => r.Activo).ToArray();
        }

        public static Articulo[] ObtenerArticulosDisponibles()
        {
            return LogicaArticulo.ObtenerArticulos()
                .Where(a => a.Activo && a.Inventario > 0)
                .ToArray();
        }
    }
}
using System;
using EntregasSA.Entidades;

namespace EntregasSA.AccesoDatos
{
    public class DatosPedido
    {
        private static Pedido[] pedidos = new Pedido[40];
        private static int contador = 0;
        public static void AgregarPedido(Pedido pedido)
        {
            //Se valida el ingreso el numero de pedido con una expresión lambda
            if (Array.Exists(pedidos, p => p != null && p.NumeroPedido == pedido.NumeroPedido))
            {
                throw new Exception("Ya existe un pedido con el mismo ID.");
            }
            //Validación para evitar que se ingresen más de 20 pedidos
            if (contador < 40)
            {
                pedidos[contador] = pedido;
                contador++;
            }
            else
            {
                throw new Exception("No se pueden agregar más de 20 pedidos.");
            }
        }
        //Se retornan con una expresión lambda todos los pedidos que no sean nulos
        public static Pedido[] ObtenerPedidos()
        {
            return pedidos.Where(p => p != null).ToArray();
        }
    }
}

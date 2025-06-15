using EntregasSA.Entidades;
using System;

namespace EntregasSA.AccesoDatos
{

    public class DatosCliente
    {
        private static Cliente[] clientes = new Cliente[20];
        private static int contador = 0;

        public static void AgregarCliente(Cliente cliente)
        {
            //Se valida el ingreso del Id con una expresión lambda
            if (Array.Exists(clientes, c => c != null && c.Id == cliente.Id))
            {
                throw new Exception("Ya existe un cliente con el mismo ID.");
            }
            //Validación para evitar que se ingresen más de 20 clientes
            if (contador < 20)
            {
                clientes[contador] = cliente;
                contador++;
            }
            else
            {
                throw new Exception("No se pueden agregar más de 20 clientes.");
            }
        }

        //Se retornan con una expresión lambda todos los clientes que no sean nulos
        public static Cliente[] ObtenerClientes()
        {
            return clientes.Where(c => c != null).ToArray();
        }

        //Logica para eliminar cliente
        public static void EliminarCliente(int id)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null && clientes[i].Id == id)
                {
                    clientes[i] = null; 
                    return;
                }
            }
        }
    }
}

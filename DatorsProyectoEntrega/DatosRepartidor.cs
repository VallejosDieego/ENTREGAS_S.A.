using System;
using EntregasSA.Entidades;
namespace EntregasSA.AccesoDatos
{
    public class DatosRepartidor
    {
        private static Repartidor[] repartidores = new Repartidor[20];
        private static int contador = 0;
        public static void AgregarRepartidor(Repartidor repartidor)
        {
            //Se valida el ingreso del Id con una expresión lambda
            if (Array.Exists(repartidores, r => r != null && r.Id == repartidor.Id))
            {
                throw new Exception("Ya existe un repartidor con el mismo ID.");
            }
            //Validación para evitar que se ingresen más de 20 repartidores
            if (contador < 20)
            {
                repartidores[contador] = repartidor;
                contador++;
            }
            else
            {
                throw new Exception("No se pueden agregar más de 20 repartidores.");
            }
        }
        //Se retornan con una expresión lambda todos los repartidores que no sean nulos
        public static Repartidor[] ObtenerRepartidores()
        {
            return repartidores.Where(r => r != null).ToArray();
        }

        //Logica para eliminar repartidor
        public static void EliminarRepartidor(int id)
        {
            for (int i = 0; i < repartidores.Length; i++)
            {
                if (repartidores[i] != null && repartidores[i].Id == id)
                {
                    repartidores[i] = null; // Elimina el repartidor estableciendo a null
                    return;
                }
            }
        }
    }
}

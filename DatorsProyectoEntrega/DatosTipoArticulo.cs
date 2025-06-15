using EntregasSA.Entidades;
using System.Linq;

namespace EntregasSA.AccesoDatos
{
    public class DatosTipoArticulo
    {
        private static TipoArticulo[] tiposArticulo = new TipoArticulo[10];
        private static int contador = 0;

        public static void AgregarTipoArticulo(TipoArticulo tipo)
        {
            //Se valida el ingeso del Id con una expresión lanmbda
            if (Array.Exists(tiposArticulo, t => t != null && t.Id == tipo.Id))
            {
                throw new Exception("Ya existe un tipo de artículo con el mismo ID.");
            }

            //Validación para evitar que se ingresen más de 10 tipos de artículo
            if (contador < 10)
            {
                tiposArticulo[contador] = tipo;
                contador++;
            }
            else
            {
                throw new Exception("No se pueden agregar más de 10 tipos de artículo.");
            }


        }
        //Se retornan con una expresión lambda todos los tipos de artículo que no sean nulos
        public static TipoArticulo[] ObtenerTiposArticulo()
        {
            return tiposArticulo.Where(t => t != null).ToArray();
        }
    }

}
// Expresiones lambda aprendidas gracias a "https://www.udemy.com/course/masterclass-completa-de-c/learn/lecture/16642290#search"

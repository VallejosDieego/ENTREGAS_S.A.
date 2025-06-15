using EntregasSA.Entidades;
using System.Linq;


namespace EntregasSA.AccesoDatos
{
    public class DatosArticulo
    {

        private static Articulo[] articulos = new Articulo[20];
        private static int contador = 0;

        public static void AgregarArticulo(Articulo articulo)
        {
            
            //Se valida el ingreso del Id con una expresión lambda
            if (Array.Exists(articulos, a => a != null && a.Id == articulo.Id))
            {
                throw new Exception("Ya existe un artículo con el mismo ID.");
            }
            //Validación para evitar que se ingresen más de 20 artículos
            if (contador < 20)
            {
                articulos[contador] = articulo;
                contador++;
            }
            else
            {
                throw new Exception("No se pueden agregar más de 20 artículos.");
            }
        }

        //Se retornan con una expresión lambda todos los artículos que no sean nulos
        public static Articulo[] ObtenerArticulos()
        {
            return articulos.Where(a => a != null).ToArray();
        }

        //Logica para eliminar articulo
        public static void EliminarArticulo(int id)
        {
            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i] != null && articulos[i].Id == id)
                {
                    articulos[i] = null; 
                    return;
                }
            }
        }

    }
}

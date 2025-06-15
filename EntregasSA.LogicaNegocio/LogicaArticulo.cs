using EntregasSA.AccesoDatos;
using EntregasSA.Entidades;
using System.Text.RegularExpressions;
using System;

namespace EntregasSA.LogicaNegocio
{
    public class LogicaArticulo
    {
        private static bool SoloLetrasYNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$");
        }

        public static void GuardarArticulo(string idStr, string nombre, TipoArticulo tipoArticulo,
            string valorStr, string inventarioStr, bool activo)
        {
            // Validar parsing y reglas de negocio
            ValidarDatosArticulo(idStr, nombre, tipoArticulo, valorStr, inventarioStr, out int id, out double valor, out int inventario);

            var articulo = new Articulo
            {
                Id = id,
                Nombre = nombre,
                TipoArticulo = tipoArticulo,
                Valor = valor,
                Inventario = inventario,
                Activo = activo
            };

            DatosArticulo.AgregarArticulo(articulo);
        }

        public static Articulo[] ObtenerArticulos()
        {
            return DatosArticulo.ObtenerArticulos();
        }

        public static void EliminarArticulo(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del artículo debe ser mayor que cero.");

            DatosArticulo.EliminarArticulo(id);
        }

        private static void ValidarDatosArticulo(string idStr, string nombre, TipoArticulo tipoArticulo,
            string valorStr, string inventarioStr, out int id, out double valor, out int inventario)
        {
            // Validar parsing
            if (!int.TryParse(idStr, out id))
                throw new ArgumentException("El ID debe ser un número válido.");

            if (!double.TryParse(valorStr, out valor))
                throw new ArgumentException("El valor debe ser un número válido.");

            if (!int.TryParse(inventarioStr, out inventario))
                throw new ArgumentException("El inventario debe ser un número entero.");

            // Validar reglas de negocio
            if (id <= 0)
                throw new ArgumentException("El ID debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (!SoloLetrasYNumeros(nombre))
                throw new ArgumentException("El nombre solo puede contener letras.");

            if (tipoArticulo == null)
                throw new ArgumentException("Debe seleccionar un tipo de artículo.");

            if (valor <= 0)
                throw new ArgumentException("El valor debe ser mayor que cero.");

            if (inventario < 0)
                throw new ArgumentException("El inventario no puede ser negativo.");
        }

        public static bool ExisteArticulo(int id)
        {
            var articulos = DatosArticulo.ObtenerArticulos();
            return articulos.Any(a => a.Id == id);
        }
    }
}
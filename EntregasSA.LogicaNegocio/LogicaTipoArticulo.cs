using EntregasSA.AccesoDatos;
using EntregasSA.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntregasSA.LogicaNegocio
{
    public class LogicaTipoArticulo
    {
        private static bool SoloLetras(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$");
        }

        public static void GuardarTipoArticulo(string idStr, string nombre, string descripcion)
        {
            ValidarDatosTipoArticulo(idStr, nombre, descripcion, out int id);

            var tipoArticulo = new TipoArticulo
            {
                Id = id,
                Nombre = nombre,
                Descripcion = descripcion
            };

            DatosTipoArticulo.AgregarTipoArticulo(tipoArticulo);
        }

        public static TipoArticulo[] ObtenerTiposArticulo()
        {
            return DatosTipoArticulo.ObtenerTiposArticulo();
        }

        private static void ValidarDatosTipoArticulo(string idStr, string nombre,
            string descripcion, out int id)
        {
            // Validar parsing
            if (!int.TryParse(idStr, out id))
                throw new ArgumentException("El ID debe ser un número válido.");

            // Validar reglas de negocio
            if (id <= 0)
                throw new ArgumentException("El ID debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (!SoloLetras(nombre))
                throw new ArgumentException("El nombre solo puede contener letras y espacios.");

            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción es obligatoria.");

            if (!SoloLetras(descripcion))
                throw new ArgumentException("La descripción solo puede contener letras y espacios.");
        }

        public static bool ExisteTipoArticulo(int id)
        {
            var tipos = DatosTipoArticulo.ObtenerTiposArticulo();
            return tipos.Any(t => t.Id == id);
        }
    }
}

using EntregasSA.AccesoDatos;
using EntregasSA.Entidades;
using System.Text.RegularExpressions;
using System;

namespace EntregasSA.LogicaNegocio
{
    public class LogicaRepartidor
    {
        private static bool SoloLetras(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$");
        }

        private static bool SoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^\d+$");
        }

        public static void GuardarRepartidor(int id, string nombre, string primerApellido,
            string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion, bool activo)
        {
            ValidarDatosRepartidor(id, nombre, primerApellido, segundoApellido,
                                 fechaNacimiento, fechaContratacion);

            var repartidor = new Repartidor
            {
                Id = id,
                Nombre = nombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                FechaNacimiento = fechaNacimiento,
                FechaContratacion = fechaContratacion,
                Activo = activo
            };

            DatosRepartidor.AgregarRepartidor(repartidor);
        }

        public static Repartidor[] ObtenerRepartidores()
        {
            return DatosRepartidor.ObtenerRepartidores();
        }

        public static void EliminarRepartidor(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del repartidor debe ser mayor que cero.");

            DatosRepartidor.EliminarRepartidor(id);
        }

        private static void ValidarDatosRepartidor(int id, string nombre, string primerApellido,
            string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (!SoloLetras(nombre))
                throw new ArgumentException("El nombre solo puede contener letras y espacios.");

            if (string.IsNullOrWhiteSpace(primerApellido))
                throw new ArgumentException("El primer apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(segundoApellido))
                throw new ArgumentException("El segundo apellido es obligatorio.");

            if (!SoloLetras(primerApellido))
                throw new ArgumentException("El primer apellido solo puede contener letras y espacios.");

            if (!SoloLetras(segundoApellido))
                throw new ArgumentException("El segundo apellido solo puede contener letras y espacios.");

            if (fechaNacimiento >= DateTime.Today)
                throw new ArgumentException("La fecha de nacimiento no puede ser igual o posterior a hoy.");

            if (fechaContratacion.Date > DateTime.Today)
                throw new ArgumentException("La fecha de contratación no puede ser posterior a hoy.");

            if (fechaContratacion.Date < fechaNacimiento)
                throw new ArgumentException("La fecha de contratación no puede ser anterior a la fecha de nacimiento.");

            // Validar que tenga al menos 18 años al momento de la contratación
            var edadContratacion = fechaContratacion.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > fechaContratacion.AddYears(-edadContratacion))
                edadContratacion--;

            if (edadContratacion < 18)
                throw new ArgumentException("El repartidor debe ser mayor de edad al momento de la contratación.");
        }

        public static bool ExisteRepartidor(int id)
        {
            var repartidores = DatosRepartidor.ObtenerRepartidores();
            return repartidores.Any(r => r.Id == id);
        }
    }
}

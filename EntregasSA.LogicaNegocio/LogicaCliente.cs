using EntregasSA.AccesoDatos;
using EntregasSA.Entidades;
using System.Text.RegularExpressions;
using System;
using System.Globalization;

namespace EntregasSA.LogicaNegocio
{
    public class LogicaCliente
    {
        private static bool SoloLetras(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$");
        }

        public static void GuardarCliente(int id, string nombre, string primerApellido,
            string segundoApellido, DateTime fechaNacimiento, bool activo)
        {
            ValidarDatosCliente(id, nombre, primerApellido, segundoApellido, fechaNacimiento);

            var cliente = new Cliente
            {
                Id = id,
                Nombre = nombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                FechaNacimiento = fechaNacimiento,
                Activo = activo
            };

            DatosCliente.AgregarCliente(cliente);
        }

        public static Cliente[] ObtenerClientes()
        {
            return DatosCliente.ObtenerClientes();
        }

        public static void EliminarCliente(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del cliente debe ser mayor que cero.");

            DatosCliente.EliminarCliente(id);
        }

        private static void ValidarDatosCliente(int id, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento)
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
        }

        public static bool ExisteCliente(int id)
        {
            var clientes = DatosCliente.ObtenerClientes();
            return clientes.Any(c => c.Id == id);
        }
    }
}


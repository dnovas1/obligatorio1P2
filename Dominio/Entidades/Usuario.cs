using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public abstract class Usuario : IValidable
    {
        // Propiedades
        public int Id { get; set; } // va a ser autonumerico
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }

        private static int ultimoId = 1;

        // Constructor
        public Usuario(string nombre, string apellido, string email, string contrasenia)
        {
            Id = ultimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contrasenia = contrasenia;
        }

        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += $"Id Usuario: {Id}\n";
            respuesta += $"Nobre: {Nombre}\n";
            respuesta += $"Apellido: {Apellido}\n";
            respuesta += $"Mail: {Email}\n";

            return respuesta;
        }

        public void Validar() 
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre del usuario no puede estar vacio.");
            }
            if (string.IsNullOrEmpty(Apellido))
            {
                throw new Exception("El apellido del usuario no puede estar vacio.");
            }
            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("El mail del usuario no puede estar vacio.");
            }
        }
    }
}

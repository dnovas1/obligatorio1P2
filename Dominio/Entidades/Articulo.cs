using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio.Entidades
{
    public class Articulo :IValidable, IEquatable<Articulo>
    {
        public int IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        private static int _ultimoId;

        public Articulo(string nombreArticulo, string categoria, decimal precio)
        {
            IdArticulo = _ultimoId++;
            NombreArticulo = nombreArticulo;
            Categoria = categoria;
            Precio = precio;
        }



        public void Validar()
        {
            if (string.IsNullOrEmpty(NombreArticulo))
            {
                throw new Exception("El nombre del articulo no puede estar vacio.");
            }
            if (string.IsNullOrEmpty(Categoria))
            {
                throw new Exception("Debe asignar una categoria al articulo.");
            }
            if (Precio <= 0)
            {
                throw new Exception("El precio del articulo debe ser mayor a 0.");
            }
        }

        public override string ToString()
        {

            string respuesta = string.Empty;
            respuesta += $"Nombre: {NombreArticulo}\n";
            respuesta += $"Categoria: {Categoria}\n";
            respuesta += $"Precio: {Precio}\n";

            return respuesta;
        }

        public bool Equals(Articulo? other)
        {
            return other != null && NombreArticulo == other.NombreArticulo;
        }
    }
}

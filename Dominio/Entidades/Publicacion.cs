using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Entidades.Publicacion;

namespace Dominio.Entidades
{
    public abstract class Publicacion :IValidable
    {
        #region Propiedades
        public int IdPublicacion { get; set; } // Id autonumérico
        public string NombrePublicacion { get; set; }
        public EstadoPublicacion Estado { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Cliente Cliente { get; set; } // Cliente que realizo la compra
        public Usuario Administrador { get; set; } // Usuario que finalizo la compra
        public DateTime? FechaFinalizacion { get; set; } // Puede ser nulo hasta que se cierra la publicación
        public List<Articulo> ListaArticulos { get; set; } // Lista de artículos en la publicación

        private static int _ultimoId = 1;

        #endregion
        #region Constructor
        public Publicacion(string nombre, EstadoPublicacion estado, DateTime fechaPublicacion, List<Articulo> listaArticulos)
        {
            IdPublicacion = _ultimoId++;
            NombrePublicacion = nombre;
            Estado = estado;
            FechaPublicacion = fechaPublicacion;
            ListaArticulos = listaArticulos;
        }
        #endregion
        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += $"IdPublicacion: {IdPublicacion} \n";
            respuesta += $"Nombre de la publicacion: {NombrePublicacion} \n";
            respuesta += $"Estado: {Estado} \n";
            respuesta += $"Fecha de publicacion: {FechaPublicacion} \n";
            respuesta += $"Cliente: {Cliente} \n";
            respuesta += $"Admin: {Administrador} \n";
            respuesta += $"Fecha de finalizacion: {FechaFinalizacion} \n";
            respuesta += $"Articulos: {ListaArticulos}";

            return respuesta;
        }
        public enum EstadoPublicacion
        {
            Abierta,
            Cerrada,
            Cancelada
        }
        public void Validar()
        {
            if (string.IsNullOrEmpty(NombrePublicacion))
            {
                throw new Exception("El nombre de la publicacion no puede estar vacio.");
            }
        }
    }
}

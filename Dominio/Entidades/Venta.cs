using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Entidades.Publicacion;

namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {
        #region Propiedades
        public bool OfertaRelampago { get; set; }
        #endregion

        #region Constructor
        public Venta(string nombre,
                     EstadoPublicacion estado,
                     DateTime fechaPublicacion,
                     List<Articulo> listaArticulos,
                     bool ofertaRelampago)
            : base(nombre, estado, fechaPublicacion, listaArticulos)
        {
            OfertaRelampago = ofertaRelampago;
        }

        #endregion

        //metodo para calcular el precio de la publicación
        public decimal CalcularPrecio()
        {
            decimal precioTotal = 0;
            foreach (var unArticulo in ListaArticulos)
            {
                precioTotal += unArticulo.Precio;
            }

            if (OfertaRelampago)
            {
                // Aplica un 20% de descuento cuando tiene la oferta
                precioTotal *= 0.8m;
            }

            return precioTotal;
        }

        public override string ToString()
        {

            string respuesta = string.Empty;
            respuesta += $"Oferta Relampago: {(OfertaRelampago ? "Sí" : "No")}\n";
            respuesta += $"Precio Total: ${CalcularPrecio()}\n";

            return base.ToString() + respuesta;
        }
    }
}
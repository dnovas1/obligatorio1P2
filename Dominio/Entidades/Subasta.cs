using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Subasta : Publicacion
    {
        #region Propiedades
        private List<Oferta> _listaOfertas = new List<Oferta>();
        #endregion

        #region Constructor
        public Subasta(string nombre,
                   EstadoPublicacion estado,
                   DateTime fechaPublicacion,
                   List<Articulo> listaArticulos)
        : base(nombre, estado, fechaPublicacion, listaArticulos)
        {

        }
        #endregion

        public void AgregarOferta(Oferta oferta)
        {
            if (oferta == null)
            {
                throw new Exception("No tiene ofertas.");
            }
            oferta.Validar();
            _listaOfertas.Add(oferta);
        }



        public Oferta ObtenerMayorOferta()
        {
            if (_listaOfertas == null || _listaOfertas.Count == 0)
            {
                return null; // Si la lista está vacía o nula, no hay ofertas que retornar entonces retorna null
            }

            Oferta mayorOferta = _listaOfertas[0]; // arranco con la primera oferta

            // recorro la listade ofertas para encontrar la oferta con el monto más alto
            foreach (var oferta in _listaOfertas)
            {
                if (oferta.Monto > mayorOferta.Monto)
                {
                    mayorOferta = oferta;
                }
            }

            return mayorOferta;
        }

        public override string ToString()
        {
            string respuesta = string.Empty;

            respuesta += $"Ofertas:\n";
            if (_listaOfertas.Count > 0)
            {
                foreach (var oferta in _listaOfertas)
                {
                    respuesta += $"{oferta}\n"; // Llama al ToString de la clase Oferta
                }
            }
            else
            {
                respuesta += "No hay ofertas en esta subasta.\n";
            }
            return base.ToString() + respuesta;
        }
    }
}

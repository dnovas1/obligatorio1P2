using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Administrador : Usuario
    {
        #region Constructor
        // Constructor
        public Administrador(string nombre, string apellido, string email, string contrasenia)
            : base(nombre, apellido, email, contrasenia)
        {
        }
        #endregion

        //para cerrar una subasta
        public void CerrarSubasta(Subasta subasta)
        {
            if (subasta.Estado == Publicacion.EstadoPublicacion.Abierta)
            {
                Oferta mejorOferta = subasta.ObtenerMayorOferta();
                if (mejorOferta != null)
                {
                    // asigno la compra al cliente que hizo la mejor oferta
                    subasta.Cliente = mejorOferta.Usuario;
                    subasta.Administrador = this;
                    subasta.FechaFinalizacion = DateTime.Now;
                    subasta.Estado = Publicacion.EstadoPublicacion.Cerrada;
                }
                else
                {
                    throw new Exception("No se puede cerrar la subasta porque no hay ofertas.");
                }
            }
            else
            {
                throw new Exception($"La subasta {subasta.NombrePublicacion} no esta abierta.");
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

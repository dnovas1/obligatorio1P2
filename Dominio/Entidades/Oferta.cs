using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Oferta : IValidable
    {
        // Propiedades
        public int IdOferta { get; set; }
        public Cliente Usuario { get; set; } // Cliente que hizo la oferta
        public decimal Monto { get; set; }
        public DateTime FechaOferta { get; set; }

        private static int _ultimoId;

        // Constructor
        public Oferta(Cliente usuario, decimal monto)
        {
            IdOferta = _ultimoId++;
            Usuario = usuario;
            Monto = monto;
            FechaOferta = DateTime.Now;
        }

        public void Validar()
        {
            if (Usuario == null)
            {
                throw new Exception("El usuario es null.");
            }
            if (Usuario.SaldoDisponible < Monto)
            {

                throw new Exception("No tiene suficiente saldo disponible.");
            }
            if (Monto < 0) 
            {
                throw new Exception("El monto debe ser mayor a 0.");
            }
            if (FechaOferta < DateTime.Now)
            {
                throw new Exception("La fecha de la oferta no puede ser anterior a la fecha actual.");
            }
        }
        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += $"Id Oferta: {IdOferta}\n";
            respuesta += $"Usuario: {Usuario.Nombre} {Usuario.Apellido} \n";
            respuesta += $"Monto: {Monto} \n";
            respuesta += $"Fecha: {FechaOferta} \n";

            return respuesta;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Cliente : Usuario
    {
        #region Propiedades
        public decimal SaldoDisponible { get; set; }
        #endregion

        #region Constructor
        public Cliente(int id, string nombre, string apellido, string email, string contrasenia, decimal saldoDisponible)
            : base(nombre, apellido, email, contrasenia)
        {
            SaldoDisponible = saldoDisponible;
        }
        #endregion

        // metodo para realizar compra
        public bool Comprar(decimal monto)
        {
            if (SaldoDisponible >= monto)
            {
                SaldoDisponible -= monto;
                return true; // Si tiene saldo para la compra devuelve true,sino false
            }
            return false;
        }

        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += $"Saldo disponible: ${SaldoDisponible}\n";

            return base.ToString() + respuesta;
        }
    }
}

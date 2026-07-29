using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Facturacion
{
    public class Pago
    {
        private int idPago;
        private int idUsuario;
        private int idInscripcion;
        private DateTime fechaPago;
        private decimal monto;
        private string metodoPago;
        private string estado;

        public Pago()
        {
        }

        public Pago(int idPago, int idUsuario, int idInscripcion, DateTime fechaPago, decimal monto, string metodoPago, string estado)
        {
            this.IdPago = idPago;
            this.IdUsuario = idUsuario;
            this.IdInscripcion = idInscripcion;
            this.FechaPago = fechaPago;
            this.Monto = monto;
            this.MetodoPago = metodoPago;
            this.Estado = estado;
        }

        public int IdPago { get => idPago; set => idPago = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdInscripcion { get => idInscripcion; set => idInscripcion = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public string Estado { get => estado; set => estado = value; }

    }
}

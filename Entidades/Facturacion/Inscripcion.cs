using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Facturacion
{
    public class Inscripcion
    {
        private int idInscripcion;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string estado;
        private int idCliente;
        private int idMembresia;

        public Inscripcion()
        {
        }

        public Inscripcion(int idInscripcion, DateTime fechaInicio, DateTime fechaFin, string estado, int idCliente, int idMembresia)
        {
            this.IdInscripcion = idInscripcion;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Estado = estado;
            this.IdCliente = idCliente;
            this.IdMembresia = idMembresia;
        }

        public int IdInscripcion { get => idInscripcion; set => idInscripcion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdMembresia { get => idMembresia; set => idMembresia = value; }

    }
}

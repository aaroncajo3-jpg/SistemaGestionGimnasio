using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class AsignacionRutina
    {
        private int idAsignacionRutina;
        private int idRutina;
        private int idEntrenador;
        private int idCliente;
        private DateTime fechaAsignacion;
        private string observaciones;
        private DateTime fechaFin;
        private bool estado;

        public AsignacionRutina() 
        {
            
        }

        public AsignacionRutina(int idAsignacionRutina, int idRutina, int idEntrenador, int idCliente, DateTime fechaAsignacion, string observaciones, DateTime fechaFin, bool estado)
        {
            this.IdAsignacionRutina = idAsignacionRutina;
            this.IdRutina = idRutina;
            this.IdEntrenador = idEntrenador;
            this.IdCliente = idCliente;
            this.FechaAsignacion = fechaAsignacion;
            this.Observaciones = observaciones;
            this.FechaFin = fechaFin;
            this.Estado = estado;
        }

        public int IdAsignacionRutina { get => idAsignacionRutina; set => idAsignacionRutina = value; }
        public int IdRutina { get => idRutina; set => idRutina = value; }
        public int IdEntrenador { get => idEntrenador; set => idEntrenador = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaAsignacion { get => fechaAsignacion; set => fechaAsignacion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}

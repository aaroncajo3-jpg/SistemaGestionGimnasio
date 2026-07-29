using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Entrenador
    {
        private int idEntrenador;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string especialidad;
        private string telefono;
        private string correo;
        private DateTime fechaIngreso;
        private bool estado;

        public Entrenador()
        {
        }

        public Entrenador(int idEntrenador, string cedula, string nombres, string apellidos, string especialidad, string telefono, string correo, DateTime fechaIngreso, bool estado)
        {
            this.IdEntrenador = idEntrenador;
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Especialidad = especialidad;
            this.Telefono = telefono;
            this.Correo = correo;
            this.FechaIngreso = fechaIngreso;
            this.Estado = estado;
        }

        public int IdEntrenador { get => idEntrenador; set => idEntrenador = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}

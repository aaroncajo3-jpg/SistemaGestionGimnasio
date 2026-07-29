using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Ejercicio
    {
        private int idEjercicio;
        private string nombre;
        private string grupoMuscular;
        private string descripcion;
        private bool estado;
        private int idMaquina;

        public Ejercicio()
        {
        }

        public Ejercicio(int idEjercicio, string nombre, string grupoMuscular, string descripcion, bool estado, int idMaquina)
        {
            this.IdEjercicio = idEjercicio;
            this.Nombre = nombre;
            this.GrupoMuscular = grupoMuscular;
            this.Descripcion = descripcion;
            this.Estado = estado;
            this.IdMaquina = idMaquina;
        }

        public int IdEjercicio { get => idEjercicio; set => idEjercicio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string GrupoMuscular { get => grupoMuscular; set => grupoMuscular = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int IdMaquina { get => idMaquina; set => idMaquina = value; }
    }
}

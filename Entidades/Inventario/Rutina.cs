using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Rutina
    {
        private int idRutina;
        private string nombre;
        private string objetivo;
        private string nivel;
        private string descripcion;
        private bool estado;

        public Rutina()
        {
        }

        public Rutina(int idRutina, string nombre, string objetivo, string nivel, string descripcion, bool estado)
        {
            this.IdRutina = idRutina;
            this.Nombre = nombre;
            this.Objetivo = objetivo;
            this.Nivel = nivel;
            this.Descripcion = descripcion;
            this.Estado = estado;
        }

        public int IdRutina { get => idRutina; set => idRutina = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Objetivo { get => objetivo; set => objetivo = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}

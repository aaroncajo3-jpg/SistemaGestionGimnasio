using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Membresia
    {
        private int idMembresia;
        private string nombre;
        private int duracionDias;
        private decimal precio;
        private string descripcion;
        private bool estado;

        public Membresia()
        {
        }

        public Membresia(int idMembresia, string nombre, int duracionDias, decimal precio, string descripcion, bool estado)
        {
            this.IdMembresia = idMembresia;
            this.Nombre = nombre;
            this.DuracionDias = duracionDias;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Estado = estado;
        }

        public int IdMembresia { get => idMembresia; set => idMembresia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int DuracionDias { get => duracionDias; set => duracionDias = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }

    }
}

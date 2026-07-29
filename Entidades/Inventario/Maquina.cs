using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Maquina
    {
        private int idMaquina;
        private string nombre;
        private string marca;
        private string estado;
        private string ubicacion;

        public Maquina()
        {
        }

        public Maquina(int idMaquina, string nombre, string marca, string estado, string ubicacion)
        {
            this.IdMaquina = idMaquina;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Estado = estado;
            this.Ubicacion = ubicacion;
        }

        public int IdMaquina { get => idMaquina; set => idMaquina = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}

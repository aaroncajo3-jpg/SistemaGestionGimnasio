using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class DetalleRutina
    {
        private int idDetalleRutina;
        private int idRutina;
        private int idEjercicio;
        private int series;
        private int repeticiones;
        private int descansoSeg;

        public DetalleRutina()
        {
        }

        public DetalleRutina(int idDetalleRutina, int idRutina, int idEjercicio, int series, int repeticiones, int descansoSeg)
        {
            this.IdDetalleRutina = idDetalleRutina;
            this.IdRutina = idRutina;
            this.IdEjercicio = idEjercicio;
            this.Series = series;
            this.Repeticiones = repeticiones;
            this.DescansoSeg = descansoSeg;
        }

        public int IdDetalleRutina { get => idDetalleRutina; set => idDetalleRutina = value; }
        public int IdRutina { get => idRutina; set => idRutina = value; }
        public int IdEjercicio { get => idEjercicio; set => idEjercicio = value; }
        public int Series { get => series; set => series = value; }
        public int Repeticiones { get => repeticiones; set => repeticiones = value; }
        public int DescansoSeg { get => descansoSeg; set => descansoSeg = value; }
    }
}

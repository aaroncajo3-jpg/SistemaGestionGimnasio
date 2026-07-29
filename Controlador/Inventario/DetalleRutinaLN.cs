using Datos.BD;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DetalleRutina = Entidades.Inventario.DetalleRutina;

namespace Controlador.Inventario
{
    public class DetalleRutinaLN
    {
        public List<DetalleRutina> ShowDetalleRutinaFiltro(string valor)
        {
            List<DetalleRutina> lista = new List<DetalleRutina>();
            DetalleRutina op;
            try
            {
                List<CP_ListarDetalleRutinaFiltroResult> auxLista = DetalleRutinaCD.ListarDetalleRutinaFiltro(valor);
                foreach (CP_ListarDetalleRutinaFiltroResult obj in auxLista)
                {
                    op = new DetalleRutina(obj.IdDetalleRutina, obj.IdRutina, obj.IdEjercicio, obj.Series, obj.Repeticiones, obj.DescansoSeg);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostar DetalleRutina con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateCliente(DetalleRutina op)
        {
            try
            {
                DetalleRutinaCD.InsertarDetalleRutina(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar DetalleRutina en la BD", ex);
            }
        }

        public bool ModificarDetalleRutina(Entidades.Inventario.DetalleRutina oc)
        {
            try
            {
                DetalleRutinaCD.ModificarDetalleRutina(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update DetalleRutina en la BD", ex);
            }
        }

        public bool EliminarDetalleRutina(Entidades.Inventario.DetalleRutina op)
        {
            try
            {
                DetalleRutinaCD.EliminarDetalleRutina(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar DetalleRutina en la BD", ex);
            }
        }

        public bool ExisteDetalleRutina(int cod)
        {
            bool ban = false;
            if (DetalleRutinaCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }

    }
}

using Datos.BD;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsignacionRutina = Entidades.Inventario.AsignacionRutina;

namespace Controlador.Inventario
{
    public class AsignacionRutinaLN
    {
        public List<AsignacionRutina> ShowAsignacionRutinaFiltro(string valor)
        {
            List<AsignacionRutina> lista = new List<AsignacionRutina>();
            AsignacionRutina op;
            try
            {
                List<CP_ListarAsignacionRutinaFiltroResult> auxLista = AsignacionRutinaCD.ListarAsignacionRutinaFiltro(valor);
                foreach (CP_ListarAsignacionRutinaFiltroResult obj in auxLista)
                {
                    op = new AsignacionRutina(obj.IdAsignacionRutina, obj.IdRutina, obj.IdEntrenador, obj.IdCliente, obj.FechaAsignacion, obj.Observaciones, obj.FechaFin, obj.Estado);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostar AsignacionRutina con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateAsignacionRutina(AsignacionRutina op)
        {
            try
            {
                AsignacionRutinaCD.InsertarAsignacionRutina(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar AsignacionRutina en la BD", ex);
            }
        }

        public bool ModificarAsignacionRutina(Entidades.Inventario.AsignacionRutina oc)
        {
            try
            {
                AsignacionRutinaCD.ModificarAsignacionRutina(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update AsignacionRutina en la BD", ex);
            }
        }

        public bool EliminarCategoria(AsignacionRutina op)
        {
            try
            {
                AsignacionRutinaCD.EliminarAsignacionRutina(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar AsignacionRutina en la BD", ex);
            }
        }

        public bool ExisteAsignacionRutina(int cod)
        {
            bool ban = false;
            if (AsignacionRutinaCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }
    }
}

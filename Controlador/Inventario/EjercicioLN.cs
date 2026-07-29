using Datos.BD;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio = Entidades.Inventario.Ejercicio;

namespace Controlador.Inventario
{
    public class EjercicioLN
    {
        public List<Ejercicio> ShowEjercicioFiltro(string valor)
        {
            List<Ejercicio> lista = new List<Ejercicio>();
            Ejercicio op;
            try
            {
                List<CP_ListarEjercicioFiltroResult> auxLista = EjercicioCD.ListarEjercicioFiltro(valor);
                foreach (CP_ListarEjercicioFiltroResult obj in auxLista)
                {
                    op = new Ejercicio(obj.IdEjercicio, obj.Nombre, obj.GrupoMuscular, obj.Descripcion, obj.Estado, obj.IdMaquina);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostrar Ejercicio con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateEjercicio(Ejercicio op)
        {
            try
            {
                EjercicioCD.InsertarEjercicio(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar Ejercicio en la BD", ex);
            }
        }

        public bool ModificarEjercicio(Entidades.Inventario.Ejercicio oc)
        {
            try
            {
                EjercicioCD.ModificarEjercicio(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update Ejercicio en la BD", ex);
            }
        }

        public bool EliminarEjercicio(Entidades.Inventario.Ejercicio op)
        {
            try
            {
                EjercicioCD.EliminarEjercicio(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar Ejercicio en la BD", ex);
            }
        }

        public bool ExisteEjercicio(int cod)
        {
            bool ban = false;
            if (EjercicioCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }

    }
}

using Datos.BD;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rutina = Entidades.Inventario.Rutina;

namespace Controlador.Inventario
{
    public class RutinaLN
    {
        public List<Rutina> ShowRutinaFiltro(string valor)
        {
            List<Rutina> lista = new List<Rutina>();
            Rutina op;
            try
            {
                List<CP_ListarRutinaFiltroResult> auxLista = RutinaCD.ListarRutinaFiltro(valor);
                foreach (CP_ListarRutinaFiltroResult obj in auxLista)
                {
                    op = new Rutina(obj.IdRutina, obj.Nombre, obj.Objetivo, obj.Nivel, obj.Descripcion, obj.Estado);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostrar Rutina con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateRutina(Rutina op)
        {
            try
            {
                RutinaCD.InsertarRutina(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar Rutina en la BD", ex);
            }
        }

        public bool ModificarRutina(Entidades.Inventario.Rutina oc)
        {
            try
            {
                RutinaCD.ModificarRutina(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update Rutina en la BD", ex);
            }
        }

        public bool EliminarRutina(Entidades.Inventario.Rutina op)
        {
            try
            {
                RutinaCD.EliminarRutina(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar Rutina en la BD", ex);
            }
        }

        public bool ExisteRutina(int cod)
        {
            bool ban = false;
            if (RutinaCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }

    }
}

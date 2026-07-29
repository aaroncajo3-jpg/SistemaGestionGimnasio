using Datos.BD;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entrenador = Entidades.Inventario.Entrenador;

namespace Controlador.Inventario
{
    public class EntrenadorLN
    {
        public List<Entrenador> ShowEntrenadorFiltro(string valor)
        {
            List<Entrenador> lista = new List<Entrenador>();
            Entrenador op;
            try
            {
                List<CP_ListarEntrenadorFiltroResult> auxLista = EntrenadorCD.ListarEntrenadorFiltro(valor);
                foreach (CP_ListarEntrenadorFiltroResult obj in auxLista)
                {
                    op = new Entrenador(obj.IdEntrenador, obj.Cedula, obj.Nombres, obj.Apellidos, obj.Especialidad, obj.Telefono, obj.Correo, obj.FechaIngreso, obj.Estado); 
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostrar Entrenador con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateEntrenador(Entrenador op)
        {
            try
            {
                EntrenadorCD.InsertarEntrenador(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar Entrenador en la BD", ex);
            }
        }

        public bool ModificarEntrenador(Entidades.Inventario.Entrenador oc)
        {
            try
            {
                EntrenadorCD.ModificarEntrenador(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update Entrenador en la BD", ex);
            }
        }

        public bool EliminarEntrenador(Entidades.Inventario.Entrenador op)
        {
            try
            {
                EntrenadorCD.EliminarEntrenador(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar Entrenador en la BD", ex);
            }
        }

        public bool ExisteEntrenador(int cod)
        {
            bool ban = false;
            if (EntrenadorCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }
    }
}

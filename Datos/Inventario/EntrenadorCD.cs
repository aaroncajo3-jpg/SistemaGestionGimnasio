using Datos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class EntrenadorCD
    {
        public static List<CP_ListarEntrenadorFiltroResult> ListarEntrenadorFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarEntrenadorFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Entrenador filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarEntrenador(Entidades.Inventario.Entrenador op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarEntrenador(op.IdEntrenador, op.Cedula, op.Nombres, op.Apellidos, op.Especialidad, op.Telefono, op.Cedula, op.FechaIngreso, op.Estado);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Entrenador", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarEntrenador(Entidades.Inventario.Entrenador op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarEntrenador(op.IdEntrenador, op.Cedula, op.Nombres, op.Apellidos, op.Especialidad, op.Telefono, op.Cedula, op.FechaIngreso, op.Estado);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar con el procedimiento almacenado", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarEntrenador(Entidades.Inventario.Entrenador op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarEntrenador(op.IdEntrenador);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar con el procedimiento almacenado", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static bool Existe(int cod)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    return db.Entrenador.Any(a => a.IdEntrenador == cod);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al verificar la existencia de entrenador.", ex);
            }
        }

    }
}

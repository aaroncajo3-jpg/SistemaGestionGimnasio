using Datos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class AsignacionRutinaCD
    {
        public static List<CP_ListarAsignacionRutinaFiltroResult> ListarAsignacionRutinaFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarAsignacionRutinaFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar AsignacionRutina filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarAsignacionRutina(Entidades.Inventario.AsignacionRutina op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarAsignacionRutina(op.IdAsignacionRutina, op.IdRutina, op.IdEntrenador, op.IdCliente, op.FechaAsignacion, op.Observaciones, op.FechaFin, op.Estado);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla AsignacionRutina", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarAsignacionRutina(Entidades.Inventario.AsignacionRutina op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarAsignacionRutina(op.IdAsignacionRutina, op.IdRutina, op.IdEntrenador, op.IdCliente, op.FechaAsignacion, op.Observaciones, op.FechaFin, op.Estado);
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

        public static void EliminarAsignacionRutina(Entidades.Inventario.AsignacionRutina op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarAsignacionRutina(op.IdAsignacionRutina);
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
                    return db.AsignacionRutina.Any(a => a.IdAsignacionRutina == cod);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al verificar la existencia de asignacion de rutina.", ex);
            }
        }

    }
}

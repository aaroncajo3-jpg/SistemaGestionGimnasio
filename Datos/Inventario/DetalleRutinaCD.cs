using Datos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class DetalleRutinaCD
    {
        public static List<CP_ListarDetalleRutinaFiltroResult> ListarDetalleRutinaFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarDetalleRutinaFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Detalle Rutina filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarDetalleRutina(Entidades.Inventario.DetalleRutina op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarDetalleRutina(op.IdDetalleRutina, op.IdRutina, op.IdEjercicio, op.Series, op.Repeticiones, op.DescansoSeg);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla DetalleRutina", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarDetalleRutina(Entidades.Inventario.DetalleRutina op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarDetalleRutina(op.IdDetalleRutina, op.IdRutina, op.IdEjercicio, op.Series, op.Repeticiones, op.DescansoSeg);
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

        public static void EliminarDetalleRutina(Entidades.Inventario.DetalleRutina op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarDetalleRutina(op.IdDetalleRutina);
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
                    return db.DetalleRutina.Any(a => a.IdDetalleRutina == cod);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al verificar la existencia de detalle de rutina.", ex);
            }
        }

    }
}

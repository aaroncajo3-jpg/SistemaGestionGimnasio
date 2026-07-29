using Datos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class EjercicioCD
    {
        public static List<CP_ListarEjercicioFiltroResult> ListarEjercicioFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarEjercicioFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Ejercicio filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarEjercicio(Entidades.Inventario.Ejercicio op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarEjercicio(op.IdEjercicio, op.Nombre, op.GrupoMuscular, op.Descripcion, op.Estado, op.IdMaquina);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Ejercicio", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarEjercicio(Entidades.Inventario.Ejercicio op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarEjercicio(op.IdEjercicio, op.Nombre, op.GrupoMuscular, op.Descripcion, op.Estado, op.IdMaquina);
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

        public static void EliminarEjercicio(Entidades.Inventario.Ejercicio op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarEjercicio(op.IdEjercicio);
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
                    return db.Ejercicio.Any(a => a.IdEjercicio == cod);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al verificar la existencia de ejercicio.", ex);
            }
        }


    }
}

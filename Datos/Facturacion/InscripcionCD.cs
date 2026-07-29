using Datos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Facturacion
{
    public class InscripcionCD
    {
        public static List<CP_ListarInscripcionFiltroResult> ListarInscripcionFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarInscripcionFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Inscripcion filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarInscripcion(Entidades.Facturacion.Inscripcion op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarInscripcion(op.IdInscripcion, op.FechaInicio, op.FechaFin, op.Estado, op.IdCliente, op.IdMembresia);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Inscripcion", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarInscripcion(Entidades.Facturacion.Inscripcion op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarInscripcion(op.IdInscripcion, op.FechaInicio, op.FechaFin, op.Estado, op.IdCliente, op.IdMembresia);
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

        public static void EliminarInscripcion(Entidades.Facturacion.Inscripcion op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarInscripcion(op.IdInscripcion);
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
                    return db.Inscripcion.Any(a => a.IdInscripcion == cod);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al verificar la existencia de inscripción.", ex);
            }
        }


    }
}

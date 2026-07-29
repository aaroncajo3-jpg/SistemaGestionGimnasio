using Datos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class MembresiaCD
    {
        public static List<CP_ListarMembresiaFiltroResult> ListarMembresiaFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarMembresiaFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Membresia filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarMembresia(Entidades.Inventario.Membresia op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarMembresia(op.IdMembresia, op.Nombre, op.DuracionDias, op.Precio, op.Descripcion, op.Estado);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Membresia", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarMembresia(Entidades.Inventario.Membresia op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarMembresia(op.IdMembresia, op.Nombre, op.DuracionDias, op.Precio, op.Descripcion, op.Estado);
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

        public static void EliminarMembresia(Entidades.Inventario.Membresia op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarMembresia(op.IdMembresia);
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
                    return db.Membresia.Any(a => a.IdMembresia == cod);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al verificar la existencia de membresia.", ex);
            }
        }

    }
}

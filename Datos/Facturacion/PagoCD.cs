using Datos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Facturacion
{
    public class PagoCD
    {
        public static List<CP_ListarPagoFiltroResult> ListarPagoFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarPagoFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Pago filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarPago(Entidades.Facturacion.Pago op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarPago(op.IdPago, op.IdUsuario, op.IdInscripcion, op.FechaPago, op.Monto, op.MetodoPago, op.Estado);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Pago", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarPago(Entidades.Facturacion.Pago op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarPago(op.IdPago, op.IdUsuario, op.IdInscripcion, op.FechaPago, op.Monto, op.MetodoPago, op.Estado);
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

        public static void EliminarPago(Entidades.Facturacion.Pago op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarPago(op.IdPago);
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
                    return db.Pago.Any(a => a.IdPago == cod);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al verificar la existencia de pago.", ex);
            }
        }

    }
}

using Datos.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class ClienteCD
    {
        public static List<CP_ListarClienteFiltroResult> ListarClienteFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarClienteFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Cliente filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarCliente(Entidades.Inventario.Cliente op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarCliente(op.IdCliente, op.IdUsuario, op.Cedula, op.Nombres, op.Apellidos, op.Sexo, op.FechaNacimiento, op.Direccion, op.Telefono, op.Correo, op.FechaRegistro, op.Estado);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Cliente", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void ModificarCliente(Entidades.Inventario.Cliente op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarCliente(op.IdCliente, op.IdUsuario, op.Cedula, op.Nombres, op.Apellidos, op.Sexo, op.FechaNacimiento, op.Direccion, op.Telefono, op.Correo, op.FechaRegistro, op.Estado);
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

        public static void EliminarCliente(Entidades.Inventario.Cliente op)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarCliente(op.IdCliente);
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
                    return db.Cliente.Any(a => a.IdCliente == cod);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al verificar la existencia de cliente.", ex);
            }
        }
    }
}

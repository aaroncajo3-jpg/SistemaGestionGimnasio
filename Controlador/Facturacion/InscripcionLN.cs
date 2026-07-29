using Datos.BD;
using Datos.Facturacion;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inscripcion = Entidades.Facturacion.Inscripcion;

namespace Controlador.Facturacion
{
    public class InscripcionLN
    {
        public List<Inscripcion> ShowInscripcionFiltro(string valor)
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            Inscripcion op;
            try
            {
                List<CP_ListarInscripcionFiltroResult> auxLista = InscripcionCD.ListarInscripcionFiltro(valor);
                foreach (CP_ListarInscripcionFiltroResult obj in auxLista)
                {
                    op = new Inscripcion(obj.IdInscripcion, obj.FechaInicio, obj.FechaFin, obj.Estado, obj.IdCliente, obj.IdMembresia);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostrar Inscripcion con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateInscripcion(Inscripcion op)
        {
            try
            {
                InscripcionCD.InsertarInscripcion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar Inscripcion en la BD", ex);
            }
        }

        public bool ModificarInscripcion(Entidades.Facturacion.Inscripcion oc)
        {
            try
            {
                InscripcionCD.ModificarInscripcion(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update Inscripcion en la BD", ex);
            }
        }

        public bool EliminarInscripcion(Entidades.Facturacion.Inscripcion op)
        {
            try
            {
                InscripcionCD.EliminarInscripcion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar Inscripcion en la BD", ex);
            }
        }

        public bool ExisteInscripcion(int cod)
        {
            bool ban = false;
            if (InscripcionCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }
    }
}

using Datos.BD;
using Datos.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pago = Entidades.Facturacion.Pago;

namespace Controlador.Facturacion
{
    public class PagoLN
    {
        public List<Pago> ShowPagoFiltro(string valor)
        {
            List<Pago> lista = new List<Pago>();
            Pago op;
            try
            {
                List<CP_ListarPagoFiltroResult> auxLista = PagoCD.ListarPagoFiltro(valor);
                foreach (CP_ListarPagoFiltroResult obj in auxLista)
                {
                    op = new Pago(obj.IdPago, obj.IdUsuario, obj.IdInscripcion, obj.FechaPago, obj.Monto, obj.MetodoPago, obj.Estado);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostrar Pago con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreatePago(Pago op)
        {
            try
            {
                PagoCD.InsertarPago(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar Pago en la BD", ex);
            }
        }

        public bool ModificarPago(Entidades.Facturacion.Pago oc)
        {
            try
            {
                PagoCD.ModificarPago(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update Pago en la BD", ex);
            }
        }

        public bool EliminarPago(Entidades.Facturacion.Pago op)
        {
            try
            {
                PagoCD.EliminarPago(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar Pago en la BD", ex);
            }
        }

        public bool ExistePago(int cod)
        {
            bool ban = false;
            if (PagoCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }
    }
}
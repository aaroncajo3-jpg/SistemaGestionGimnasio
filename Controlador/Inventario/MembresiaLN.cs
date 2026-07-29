using Datos.BD;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Membresia = Entidades.Inventario.Membresia;

namespace Controlador.Inventario
{
    public class MembresiaLN
    {
        public List<Membresia> ShowMembresiaFiltro(string valor)
        {
            List<Membresia> lista = new List<Membresia>();
            Membresia op;
            try
            {
                List<CP_ListarMembresiaFiltroResult> auxLista = MembresiaCD.ListarMembresiaFiltro(valor);
                foreach (CP_ListarMembresiaFiltroResult obj in auxLista)
                {
                    op = new Membresia(obj.IdMembresia, obj.Nombre, obj.DuracionDias, obj.Precio, obj.Descripcion, obj.Estado);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostrar Membresia con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateMembresia(Membresia op)
        {
            try
            {
                MembresiaCD.InsertarMembresia(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar Membresia en la BD", ex);
            }
        }

        public bool ModificarMembresia(Entidades.Inventario.Membresia oc)
        {
            try
            {
                MembresiaCD.ModificarMembresia(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update Membresia en la BD", ex);
            }
        }

        public bool EliminarMembresia(Entidades.Inventario.Membresia op)
        {
            try
            {
                MembresiaCD.EliminarMembresia(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar Membresia en la BD", ex);
            }
        }

        public bool ExisteMembresia(int cod)
        {
            bool ban = false;
            if (MembresiaCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }
    }
}

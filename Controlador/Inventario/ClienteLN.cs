using Datos.BD;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente = Entidades.Inventario.Cliente;

namespace Controlador.Inventario
{
    public class ClienteLN
    {
        public List<Cliente> ShowClientesFiltro(string valor)
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente op;
            try
            {
                List<CP_ListarClienteFiltroResult> auxLista = ClienteCD.ListarClienteFiltro(valor);
                foreach (CP_ListarClienteFiltroResult obj in auxLista)
                {
                    op = new Cliente(obj.IdCliente, obj.IdUsuario, obj.Cedula, obj.Nombres, obj.Apellidos, obj.Sexo, obj.FechaNacimiento, obj.Direccion, obj.Telefono, obj.Correo, obj.FechaRegistro, obj.Estado);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostar Clientes con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateCliente(Cliente op)
        {
            try
            {
                ClienteCD.InsertarCliente(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar Cliente en la BD", ex);
            }
        }

        public bool ModificarCliente(Entidades.Inventario.Cliente oc)
        {
            try
            {
                ClienteCD.ModificarCliente(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update Cliente en la BD", ex);
            }
        }

        public bool EliminarCliente(Entidades.Inventario.Cliente op)
        {
            try
            {
                ClienteCD.EliminarCliente(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar Cliente en la BD", ex);
            }
        }

        public bool ExisteCliente(int cod)
        {
            bool ban = false;
            if (ClienteCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }

    }
}

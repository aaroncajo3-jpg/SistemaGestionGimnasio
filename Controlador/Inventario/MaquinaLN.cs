using Datos.BD;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maquina = Entidades.Inventario.Maquina;

namespace Controlador.Inventario
{
    public class MaquinaLN
    {
        public List<Maquina> ShowMaquinaFiltro(string valor)
        {
            List<Maquina> lista = new List<Maquina>();
            Maquina op;
            try
            {
                List<CP_ListarMaquinaFiltroResult> auxLista = MaquinaCD.ListarMaquinaFiltro(valor);
                foreach (CP_ListarMaquinaFiltroResult obj in auxLista)
                {
                    op = new Maquina(obj.IdMaquina, obj.Nombre, obj.Marca, obj.Estado, obj.Ubicacion);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al mostrar Maquina con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateMaquina(Maquina op)
        {
            try
            {
                MaquinaCD.InsertarMaquina(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al insertar Maquina en la BD", ex);
            }
        }

        public bool ModificarMaquina(Entidades.Inventario.Maquina oc)
        {
            try
            {
                MaquinaCD.ModificarMaquina(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al update Maquina en la BD", ex);
            }
        }

        public bool EliminarMaquina(Entidades.Inventario.Maquina op)
        {
            try
            {
                MaquinaCD.EliminarMaquina(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new ControladorExcepciones("Error al eliminar Maquina en la BD", ex);
            }
        }

        public bool ExisteMaquina(int cod)
        {
            bool ban = false;
            if (MaquinaCD.Existe(cod) == false)
            {
                ban = true;
            }
            return ban;
        }
    }
}

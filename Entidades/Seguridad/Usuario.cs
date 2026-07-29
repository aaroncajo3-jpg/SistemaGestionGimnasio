using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string contrasena;
        private string rol;
        private bool estado;

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string nombreUsuario, string contrasena, string rol, bool estado)
        {
            this.IdUsuario = idUsuario;
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.Rol = rol;
            this.Estado = estado;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Rol { get => rol; set => rol = value; }
        public bool Estado { get => estado; set => estado = value; }

    }
}

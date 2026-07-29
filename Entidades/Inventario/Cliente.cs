using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Cliente
    {
        private int idCliente;
        private int idUsuario;
        private string cedula;
        private string nombres;
        private string apellidos;
        private char sexo;
        private DateTime fechaNacimiento;
        private string direccion;
        private string telefono;
        private string correo;
        private DateTime fechaRegistro;
        private bool estado;

        public Cliente()
        {
        }

        public Cliente(int idCliente, int idUsuario, string cedula, string nombres, string apellidos, char sexo, DateTime fechaNacimiento, string direccion, string telefono, string correo, DateTime fechaRegistro, bool estado)
        {
            this.IdCliente = idCliente;
            this.IdUsuario = idUsuario;
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.FechaRegistro = fechaRegistro;
            this.Estado = estado;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public bool Estado { get => estado; set => estado = value; }


    }
}

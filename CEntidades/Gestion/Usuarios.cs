using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CEntidades.Gestion
{
    public class Usuarios
    {
        private int idUsuario;
        private string cedula;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string ocupacion;
        public Usuarios()
        {
        }

        public Usuarios(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }
        public Usuarios(int idUsuario, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string ocupacion)
        {
            this.idUsuario = idUsuario;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.ocupacion = ocupacion;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Ocupacion { get => ocupacion; set => ocupacion = value; }
    }
}

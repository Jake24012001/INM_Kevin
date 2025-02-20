using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Gestion
{
    public class Propietario
    {
        private int idPropietario;
        private string cedula;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private string estadoVivienda;

        public Propietario()
        {
        }

        public Propietario(int idPropietario)
        {
            this.idPropietario = idPropietario;
        }

        public Propietario(int idPropietario, string cedula, string nombre, string apellido, string telefono, string email, string estadoVivienda)
        {
            this.idPropietario = idPropietario;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
            this.estadoVivienda = estadoVivienda;
        }

        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string EstadoVivienda { get => estadoVivienda; set => estadoVivienda = value; }
    }
}

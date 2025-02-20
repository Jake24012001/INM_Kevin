using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Gestion
{
    public class Ciudad
    {
        private int idCiudad;
        private int codigo;
        private string nombreCiudad;

        public Ciudad()
        {
        }

        public Ciudad(int idCiudad)
        {
            this.idCiudad = idCiudad;
        }
        public Ciudad(int idCiudad, int codigo, string nombreCiudad)
        {
            this.idCiudad = idCiudad;
            this.codigo = codigo;
            this.nombreCiudad = nombreCiudad;
        }

        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }
    }
}

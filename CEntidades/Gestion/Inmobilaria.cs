using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Gestion
{
    public class Inmobilaria
    {
        private int idInmobilaria;
        private int nOficinas;
        private int nReferencia;
        private string tipo;
        private string descipcion;
        private int idCiudad;
        private Decimal precio;
        private int idPropietario;
        private int idVisitas;

        public Inmobilaria()
        {
        }

        public Inmobilaria(int idInmobilaria)
        {
            this.idInmobilaria = idInmobilaria;
        }

        public Inmobilaria(int idInmobilaria, int nOficinas, int nReferencia, string tipo, string descipcion, int idCiudad, decimal precio, int idPropietario, int idVisitas)
        {
            this.idInmobilaria = idInmobilaria;
            this.nOficinas = nOficinas;
            this.nReferencia = nReferencia;
            this.tipo = tipo;
            this.descipcion = descipcion;
            this.idCiudad = idCiudad;
            this.precio = precio;
            this.idPropietario = idPropietario;
            this.idVisitas = idVisitas;
        }

        public int IdInmobilaria { get => idInmobilaria; set => idInmobilaria = value; }
        public int NOficinas { get => nOficinas; set => nOficinas = value; }
        public int NReferencia { get => nReferencia; set => nReferencia = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descipcion { get => descipcion; set => descipcion = value; }
        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public int IdVisitas { get => idVisitas; set => idVisitas = value; }
    }
}

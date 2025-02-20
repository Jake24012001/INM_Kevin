using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Gestion
{
    public class Visitas
    {
        private int idVisitas;
        private DateTime fechaV;
        private string horaV;
        private int idUsuario;
        private string comentario;

        public Visitas()
        {
        }

        public Visitas(int idVisitas)
        {
            this.idVisitas = idVisitas;
        }

        public Visitas(int idVisitas, DateTime fechaV, string horaV, int idUsuario, string comentario) : this(idVisitas)
        {
            this.fechaV = fechaV;
            this.horaV = horaV;
            this.idUsuario = idUsuario;
            this.comentario = comentario;
        }

        public int IdVisitas { get => idVisitas; set => idVisitas = value; }
        public DateTime FechaV { get => fechaV; set => fechaV = value; }
        public string HoraV { get => horaV; set => horaV = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Comentario { get => comentario; set => comentario = value; }
    }
}

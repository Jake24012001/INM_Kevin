using CDatos;
using CDatos.Gestion;
using CEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CLogica.Gestion
{
    public class VisitasLN
    {
        public List<CEntidades.Gestion.Visitas> ViewCategoria()
        {
            List<CEntidades.Gestion.Visitas> lista = new List<CEntidades.Gestion.Visitas>();
            CEntidades.Gestion.Visitas oc;
            try
            {
                List<CDatos.Visitas> auxLista = VisitasCD.listarVisitas();
                foreach (CDatos.Visitas obj in auxLista)
                {
                    oc = new CEntidades.Gestion.Visitas(obj.idVisitas, obj.FechaV, obj.HoraV,obj.idUsuario,obj.Comentario);
                    lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al mostar visitas de la tabla de BD", ex);
            }
            finally
            {

            }
            return lista;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Gestion
{
    public class VisitasCD
    {
        public static List<Visitas> listarVisitas()
        {
            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    return DB.Visitas.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al listar la tabla visitas", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarVisitas(CEntidades.Gestion.Visitas oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_InsertarVisitas(oc.IdVisitas, oc.FechaV, oc.HoraV, oc.IdUsuario, oc.Comentario);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al insertar tabla visitas", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarVisitas(CEntidades.Gestion.Visitas oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_ModificarVisitas(oc.IdVisitas, oc.FechaV, oc.HoraV, oc.IdUsuario, oc.Comentario);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al modificar tabla visitas", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarVisitas(CEntidades.Gestion.Visitas oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_EliminarVisitas(oc.IdVisitas);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al eliminar tabla visitas", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Gestion
{
    public class PropietarioCD
    {
        public static List<Propietario> listarPropitario()
        {
            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    return DB.Propietario.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al listar la tabla propietario", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarPropietario(CEntidades.Gestion.Propietario oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_InsertarPropietario(oc.IdPropietario, oc.Cedula, oc.Nombre, oc.Apellido, oc.Telefono, oc.Email, oc.EstadoVivienda);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al insertar tabla propietario", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarPropietario(CEntidades.Gestion.Propietario oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_ModificarPropietario(oc.IdPropietario,oc.Cedula,oc.Nombre,oc.Apellido,oc.Telefono,oc.Email,oc.EstadoVivienda);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al modificar tabla propietario", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarPropietario(CEntidades.Gestion.Propietario oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_EliminarPropietario(oc.IdPropietario);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al eliminar tabla propietario", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}

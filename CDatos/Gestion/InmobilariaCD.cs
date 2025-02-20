using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Gestion;
namespace CDatos.Gestion
{
    public class InmobilariaCD
    {
        public static List<Inmobilaria> listarCategoria()
        {
            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    return DB.Inmobilaria.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al listar la tabla inmobilaria", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarInmobilaria(CEntidades.Gestion.Inmobilaria oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_InsertarInmobilaria(oc.IdInmobilaria,oc.NOficinas,oc.NReferencia,oc.Tipo,oc.Descipcion,oc.IdCiudad,oc.Precio,oc.IdPropietario,oc.IdVisitas);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al insertar tabla inmobilaria", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarInmobilaria(CEntidades.Gestion.Inmobilaria oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_ModificarInmobilaria(oc.IdInmobilaria,oc.NOficinas,oc.NReferencia,oc.Tipo,oc.Descipcion,oc.IdCiudad,oc.Precio,oc.IdPropietario,oc.IdVisitas);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al modificar tabla inmobilaria", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarInmobilaria(CEntidades.Gestion.Inmobilaria oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_EliminarInmobilaria(oc.IdInmobilaria);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al eliminar tabla inmobilaria", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}

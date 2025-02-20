using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Gestion
{
    public class UsuariosCD
    {
        public static List<Usuarios> listarUsuarios()
        {
            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    return DB.Usuarios.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al listar la tabla usuarios", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarUsuarios(CEntidades.Gestion.Usuarios oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_InsertarUsuarios(oc.IdUsuario, oc.Cedula, oc.Nombre, oc.Apellido, oc.FechaNacimiento, oc.Ocupacion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al insertar tabla usuarios", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarUsuarios(CEntidades.Gestion.Usuarios oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_ModificarUsuarios(oc.IdUsuario, oc.Cedula, oc.Nombre, oc.Apellido, oc.FechaNacimiento, oc.Ocupacion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al modificar tabla usuarios", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarUsuarios(CEntidades.Gestion.Usuarios oc)
        {

            BDINMDataContext DB = null;
            try
            {

                using (DB = new BDINMDataContext())
                {
                    DB.CP_EliminarUsuarios(oc.IdUsuario);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al eliminar tabla usuarios", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}

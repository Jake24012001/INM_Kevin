using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Gestion
{
    class CiudadCD
    {
        public static List<Ciudad> listarCiudades()
        {
            BDINMDataContext bd = new BDINMDataContext();
            try
            {
                using (bd = new BDINMDataContext())
                {
                    return bd.Ciudad.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Excepciones("Error al listar ciudades: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
    }
}

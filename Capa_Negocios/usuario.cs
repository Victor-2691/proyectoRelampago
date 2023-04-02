using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace Capa_Negocios
{
    public class UsuarioMethods
    {
        private tiusr7pl_proyecto_relampagoEntities1 db = new tiusr7pl_proyecto_relampagoEntities1();
        public bool login(string usuario, string contra)
        {
            try
            {
                if ((db.Usuario.Count(e => e.usuario1 == usuario) > 0) && ((db.Usuario.Count(e => e.contra == contra) > 0)))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace Capa_Negocios
{
    public class usuario
    {
        private tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities();
        public bool login(string usuario, string contra)
        {
            try
            {
                if ((db.Usuarios.Count(e => e.usuario1 == usuario) > 0) && ((db.Usuarios.Count(e => e.contra == contra) > 0))  )
                {
                    return true;
                }
                return false;
            }   

            catch (Exception )
            {

                throw;
           
            }


        }


    }
}

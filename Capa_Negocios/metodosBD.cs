using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace Capa_Negocios
{
    public class metodosBD
    {

        public void selectusuarios()
        {
            try
            {
                tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities();
                var query = from u in db.Usuario
                            select u;

                List<Usuario> usuariosLista = query.ToList();

                foreach (var item in usuariosLista)
                {
                    string usuario = item.usuario1;
                    string contra = item.contra;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
        }
    }
}


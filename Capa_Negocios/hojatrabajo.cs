using capa_datos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
  public class hojatrabajo
    {

        private tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities();
        public int agregarhojatrabajo(string usuario, DateTime fecha, bool estado)
        {
            try
            {

                Hoja_Resultados new_hoja = new Hoja_Resultados
                {
                    usuario = usuario,
                    Fecha_registro = fecha,
                    estado = estado
                };
                db.Hoja_Resultados.Add(new_hoja);
                db.SaveChanges();


                var query = (from d in db.Hoja_Resultados
                             select d.Id_hoja_resultados);

                return query.Max();
              
                
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}

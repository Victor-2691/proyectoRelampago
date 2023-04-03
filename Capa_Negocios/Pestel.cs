using capa_datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class PestelMethods
    {
        public int guardarPestel(int idFactor, string clasificacion, int politico, int economico, int social, int tecnologico, int ecologico, int legal, string justificacion, int idHojaResultado)
        {
            using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
            {
                try
                {
                    Pestel iPestel = new Pestel
                    {
                        Id_factor = idFactor,
                        clasificacion_factor = clasificacion,
                        Politico = politico,
                        Economico = economico,
                        Social = social,
                        Tecnologico = tecnologico,
                        Ecologico = ecologico,
                        Legal = legal,
                        Comentario = justificacion,
                        Id_hoja_resultados = idHojaResultado
                    };

                    db.Pestel.Add(iPestel);
                    db.SaveChanges();

                    var query = from i in db.Ideas
                                select i.Id_idea;

                    return query.Max();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void modificasrInfoPestel(int id, string clasificacion, bool economico, bool politico, bool social, bool tecnologico, bool ecologico, bool legal, string comentario)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Pestel new_pestel = new Pestel();
                    new_pestel.Id_pestel = id;
                    new_pestel.clasificacion_factor = clasificacion;
                    new_pestel.Economico = economico;
                    new_pestel.Social = social;
                    new_pestel.Tecnologico = tecnologico;
                    new_pestel.Ecologico = ecologico;
                    new_pestel.Legal = legal;
                    new_pestel.Comentario = comentario;

                    db.Entry(new_pestel).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

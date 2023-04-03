using capa_datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class Idea
    {
        private int _idIdea;
        private string _Idea;

        public int IdIdea { get => _idIdea; set => _idIdea = value; }
        public string DescripcionIdea { get => _Idea; set => _Idea = value; }

        public int guardarIdea(int idCaracteristica, string idea, int idHojaResultado)
        {
            using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
            {
                try
                {
                    Ideas iIdea = new Ideas
                    {
                        Id_caracteristica = idCaracteristica,
                        idea = idea,
                        Id_hoja_resultados = idHojaResultado
                    };

                    db.Ideas.Add(iIdea);
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

        public void modificarIdea(int idIdea, string ideaNueva)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    var objIdea = db.Ideas.Find(idIdea);

                    objIdea.idea = ideaNueva;

                    db.Entry(objIdea).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ArrayList obtenerIdeas(int idHojaResultado)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    var ideas = from i in db.Ideas
                                where i.Id_hoja_resultados == idHojaResultado
                                select new
                                {
                                    i.Id_idea,
                                    i.idea
                                };

                    ArrayList arrayIdeas = new ArrayList();
                    foreach (var sr in ideas)
                    {
                        Idea iIdea = new Idea();

                        iIdea.IdIdea = sr.Id_idea;
                        iIdea.DescripcionIdea = sr.idea;

                        arrayIdeas.Add(iIdea);
                    }
                    return arrayIdeas;               
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           
        }
    }
}
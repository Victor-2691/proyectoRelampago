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
        #region Ideas

        public int guardarIdea(int idCaracteristica, string idea, int idHojaResultado)
        {
            using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
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
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
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

        public DataTable VerIdeas()
        {
            DataTable dt = new DataTable();

            try
            {

                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    var lista = from d in db.Ideas
                                select d;
                    dt = ConvertirListaToDataTable(lista.ToList());
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

        public void EliminarIdeas(int idIdea)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    Ideas new_idea = new Ideas();
                    new_idea = db.Ideas.Find(idIdea);

                    db.Ideas.Remove(new_idea);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region MetodosInternos

        private DataTable ConvertirListaToDataTable(IList data)
        {

            var properties = TypeDescriptor.GetProperties(typeof(Ideas));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (Idea item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties) row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        #endregion
    }
}

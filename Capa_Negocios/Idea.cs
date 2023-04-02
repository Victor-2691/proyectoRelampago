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
    public class Idea
    {
        #region Ideas

        public void AgregarIdea(string idea)
        {
            using (tiusr7pl_proyecto_relampagoEntities1 db = new tiusr7pl_proyecto_relampagoEntities1())
            {
                try
                {

                    Ideas new_idea = new Ideas();
                    new_idea.idea = idea;

                    db.Ideas.Add(new_idea);
                    db.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public DataTable VerIdeas()
        {
            DataTable dt = new DataTable();

            try
            {

                using (tiusr7pl_proyecto_relampagoEntities1 db = new tiusr7pl_proyecto_relampagoEntities1())
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

        public void ModificarIdeas(int idIdea, string idea)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities1 db = new tiusr7pl_proyecto_relampagoEntities1())
                {
                    Ideas new_idea = new Ideas();
                    new_idea.Id_idea = idIdea;
                    new_idea.idea = idea;

                    db.Entry(new_idea).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void EliminarIdeas(int idIdea)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities1 db = new tiusr7pl_proyecto_relampagoEntities1())
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

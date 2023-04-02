using capa_datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class Factor
    {
        public void agregarFactores(string factor, int idIdea, bool idTipoFactor)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    ////Factores new_factor = new Factores();
                    ////new_factor.aspectoPositivo = factor;
                    ////new_factor.Id_idea= idIdea;
                    ////new_factor.id_tipo_factor = idTipoFactor; 

                    //db.Factores.Add(new_factor);
                    //db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public DataTable verFactores()
        {
            DataTable dt = new DataTable();

            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    var factores = from d in db.Factores
                                          select d;
                    dt = ConvertirListaToDataTable(factores.ToList());
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

        public void modificarFactores(int id, string factor)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    //Factores new_factor = new Factores();
                    //new_factor.Id_factor= id;
                    //new_factor.factor= factor;

                    //db.Entry(new_factor).State = System.Data.Entity.EntityState.Modified;
                    //db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void eliminarFactores(int id, string factor)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    Factores new_factor = new Factores();
                    new_factor = db.Factores.Find(id);

                    db.Factores.Remove(new_factor);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void agregarTipoFactor(string estado)
        {
            using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
            {
                //Tipo_Factor new_factor = new Tipo_Factor();
                //new_factor.Estado = estado;

                //db.Tipo_Factor.Add(new_factor);
                //db.SaveChanges();
            }
        }

        #region MetodosInternos

        private DataTable ConvertirListaToDataTable(IList data)
        {

            var properties = TypeDescriptor.GetProperties(typeof(Idea));

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

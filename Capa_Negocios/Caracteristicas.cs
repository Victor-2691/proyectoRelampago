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
    public class Caracteristicas
    {
        #region Caracteristicas

        public void agregarCaracteristica(string carac)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Caracteristica new_caracteristica = new Caracteristica();
                    new_caracteristica.caracteristica1 = carac;

                    db.Caracteristicas.Add(new_caracteristica);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public DataTable verCaracteristicas()
        {
            DataTable dt = new DataTable();

            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    var caracteristicas = from d in db.Caracteristicas
                                select d;
                    dt = ConvertirListaToDataTable(caracteristicas.ToList());
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

        public void modificarCaracteristica(int id, string carac)
        {
            try
            {
                using(tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Caracteristica new_caracteristica = new Caracteristica();
                    new_caracteristica.Id_caracteristica = id;
                    new_caracteristica.caracteristica1 = carac;

                    db.Entry(new_caracteristica).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public void eliminarCaracteristica(int id, string caracteristica)
        {
            try
            {
                using(tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Caracteristica new_caracteristica = new Caracteristica();
                    new_caracteristica = db.Caracteristicas.Find(id);

                    db.Caracteristicas.Remove(new_caracteristica);
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

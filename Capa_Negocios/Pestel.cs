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

        public void agregarInfoPestel(string clasificacion, bool economico, bool politico, bool social, bool tecnologico, bool ecologico, bool legal, string comentario, int idFactor)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Pestel new_pestel = new Pestel();
                    new_pestel.clasificacion_factor = clasificacion;
                    new_pestel.Economico = economico;
                    new_pestel.Politico = politico;
                    new_pestel.Social = social;
                    new_pestel.Tecnologico = tecnologico;
                    new_pestel.Ecologico = ecologico;
                    new_pestel.Legal = legal;
                    new_pestel.Comentario = comentario;
                    new_pestel.Id_factor = idFactor;

                    db.Pestel.Add(new_pestel);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public DataTable verInfoPestel()
        {

            DataTable dt = new DataTable();

            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    var lista = from d in db.Pestel
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

        public void eliminarInfoPestel(int id)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Pestel new_pestel = new Pestel();
                    new_pestel = db.Pestel.Find(id);

                    db.Pestel.Remove(new_pestel);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
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

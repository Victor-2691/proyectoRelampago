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
    public class Caracteristica
    {
        private int _idCaracteristica;
        private string _Caracteristica;

        public int IdCaracteristica { get => _idCaracteristica; set => _idCaracteristica = value; }
        public string DescripcionCaracteristica { get => _Caracteristica; set => _Caracteristica = value; }

        #region Caracteristicas

        public void agregarCaracteristica(string usuario, int hojaresultados, string carac)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Caracteristicas new_caracteristica = new Caracteristicas();
                    new_caracteristica.caracteristica = carac;
                    new_caracteristica.usuario = usuario;
                    new_caracteristica.Id_hoja_resultados = hojaresultados;
                    db.Caracteristicas.Add(new_caracteristica);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public ArrayList obtenerCaracteristicas(int idHojaResultado)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    var caracteristicas = from c in db.Caracteristicas
                                          where c.Id_hoja_resultados == idHojaResultado
                                          select c;

                    ArrayList arrayCaracteristicas = new ArrayList();
                    foreach (var sr in caracteristicas)
                    {
                        Caracteristica iCaracteristica = new Caracteristica();

                        iCaracteristica.IdCaracteristica = sr.Id_caracteristica;
                        iCaracteristica.DescripcionCaracteristica = sr.caracteristica;

                        arrayCaracteristicas.Add(iCaracteristica);
                    }
                    return arrayCaracteristicas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificarCaracteristica(int id, string carac)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Caracteristicas new_caracteristica = new Caracteristicas();
                    new_caracteristica.Id_caracteristica = id;
                    new_caracteristica.caracteristica = carac;

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
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Caracteristicas new_caracteristica = new Caracteristicas();
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
            var properties = TypeDescriptor.GetProperties(typeof(Caracteristicas));

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

using capa_datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
  public class HojaResultado
    {

        private tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3();
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

        public DataTable VerHojasResultado()
        {
            DataTable dt = new DataTable();

            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    var lst = from d in db.Hoja_Resultados
                              select d;
                    dt = ConvertirListaToDataTable(lst.ToList());
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;

        }//FN VertodosUsuarios


        private DataTable ConvertirListaToDataTable(IList data)
        {

            var properties = TypeDescriptor.GetProperties(typeof(Hoja_Resultados));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (Hoja_Resultados item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties) row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }


    }
}

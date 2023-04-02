using capa_datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class Factor
    {
        private int _idFactor;
        private string _descripcionCaracteristica;
        private string _descripcionIdea;
        private string _aspectoPositivo;
        private string _aspectoNegativo;

        public int IdFactor { get => _idFactor; set => _idFactor = value; }
        public string DescripcionCaracteristica { get => _descripcionCaracteristica; set => _descripcionCaracteristica = value; }
        public string DescripcionIdea { get => _descripcionIdea; set => _descripcionIdea = value; }
        public string AspectoPositivo { get => _aspectoPositivo; set => _aspectoPositivo = value; }
        public string AspectoNegativo { get => _aspectoNegativo; set => _aspectoNegativo = value; }

        public void ingresarFactoresNull(int idIdea, int idHojaResultado)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    Factores iFactor = new Factores
                    {
                        Id_idea = idIdea,
                        Id_hoja_resultados = idHojaResultado
                    };

                    db.Factores.Add(iFactor);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void modificarFactor(int idFactor, string aspectoPositivo, string aspectoNegativo)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    var objFactor = db.Factores.Find(idFactor);

                    objFactor.aspectoPositivo = aspectoPositivo;
                    objFactor.aspectoNegativo = aspectoNegativo;

                    db.Entry(objFactor).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable obtenerFactores(int idHojaResultado)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities3 db = new tiusr7pl_proyecto_relampagoEntities3())
                {
                    var factores = from f in db.Factores
                                   join i in db.Ideas on f.Id_idea equals i.Id_idea
                                   join c in db.Caracteristicas on i.Id_caracteristica equals c.Id_caracteristica
                                   where f.Id_hoja_resultados == idHojaResultado
                                   select new
                                   {
                                       f.Id_factor,
                                       c.caracteristica,
                                       i.idea,
                                       f.aspectoPositivo,
                                       f.aspectoNegativo
                                   };

                    DataTable dtFactores = generarDataTable().Copy();
                    DataRow datosFactor;
                    foreach (var sr in factores)
                    {
                        datosFactor = dtFactores.NewRow();
                        datosFactor["idFactor"] = sr.Id_factor;
                        datosFactor["Caracteristica"] = sr.caracteristica;
                        datosFactor["Idea"] = sr.idea;
                        datosFactor["AspectoPositivo"] = sr.aspectoPositivo == null ? "" : sr.aspectoPositivo;
                        datosFactor["AspectoNegativo"] = sr.aspectoNegativo == null ? "" : sr.aspectoNegativo;

                        dtFactores.Rows.Add(datosFactor);
                    }
                    return dtFactores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private DataTable generarDataTable()
        {
            DataTable dtFactores = new DataTable("Factores");

            DataColumn dtColumna = new DataColumn
            {
                AllowDBNull = false,
                Caption = "idFactor",
                ColumnName = "idFactor",
                DataType = typeof(string)
            };
            dtFactores.Columns.Add(dtColumna);

            dtColumna = new DataColumn
            {
                AllowDBNull = false,
                Caption = "Caracteristica",
                ColumnName = "Caracteristica",
                DataType = typeof(string)
            };
            dtFactores.Columns.Add(dtColumna);

            dtColumna = new DataColumn
            {
                AllowDBNull = false,
                Caption = "Idea",
                ColumnName = "Idea",
                DataType = typeof(string)
            };
            dtFactores.Columns.Add(dtColumna);

            dtColumna = new DataColumn
            {
                AllowDBNull = false,
                Caption = "AspectoPositivo",
                ColumnName = "AspectoPositivo",
                DataType = typeof(string)
            };
            dtFactores.Columns.Add(dtColumna);

            dtColumna = new DataColumn
            {
                AllowDBNull = false,
                Caption = "AspectoNegativo",
                ColumnName = "AspectoNegativo",
                DataType = typeof(string)
            };
            dtFactores.Columns.Add(dtColumna);

            return dtFactores;
        }
    }
}

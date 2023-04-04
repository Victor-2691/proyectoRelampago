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
    public class PestelMethods
    {

        private string _aspectonegativo;
        private string _aspectopositivo;
        private bool _politico = false;
        private bool _economico = false;
        private bool _social = false;
        private bool _tecnologico = false;
        private bool _ecologico = false;
        private bool _legal = false;

        public string Aspectonegativo { get => _aspectonegativo; set => _aspectonegativo = value; }
        public string AspectoPositivo { get => _aspectopositivo; set => _aspectopositivo = value; }
        public bool Politico { get => _politico; set => _politico = value; }
        public bool Economico { get => _economico; set => _economico = value; }
        public bool Social { get => _social; set => _social = value; }
        public bool Tecnologico { get => _tecnologico; set => _tecnologico = value; }
        public bool Ecologico { get => _ecologico; set => _ecologico = value; }
        public bool Legal { get => _legal; set => _legal = value; }


        public int guardarPestel(int idFactor, int tipoFactor, int clasificacion, int politico, int economico, int social, int tecnologico, int ecologico, int legal, string justificacion, int idHojaResultado)
        {
            using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
            {
                try
                {
                    Pestel iPestel = new Pestel
                    {
                        Id_factor = idFactor,
                        tipoFactor = Convert.ToBoolean(tipoFactor),
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

                    var query = from p in db.Pestel
                                select p.Id_pestel;

                    return query.Max();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }

        public void modificarPestel(int idPestel, int clasificacion, int politico, int economico, int social, int tecnologico, int ecologico, int legal, string justificacion)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    var objPestel = db.Pestel.Find(idPestel);

                    objPestel.clasificacion_factor = clasificacion;
                    objPestel.Politico = politico;
                    objPestel.Economico = economico;
                    objPestel.Social = social;
                    objPestel.Tecnologico = tecnologico;
                    objPestel.Ecologico = ecologico;
                    objPestel.Legal = legal;
                    objPestel.Comentario = justificacion;

                    db.Entry(objPestel).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //public ArrayList verInfoPestel(int hojatrabajo)
        //{        
        //    try
        //    {
        //        using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
        //        {
        //            ArrayList arrayPestel = new ArrayList();
        //            var query = from f in db.Factores
        //                        from p in db.Pestel
        //                        where f.Id_factor == p.Id_factor && p.Id_hoja_resultados == hojatrabajo
        //                        select new
        //                        {
        //                            f.aspectoPositivo,
        //                            f.aspectoNegativo,
        //                            p.Politico,
        //                            p.Economico,
        //                            p.Social,
        //                            p.Tecnologico,
        //                            p.Ecologico,
        //                            p.Legal
        //                        };

        //            foreach (var sr in query)
        //            {
        //                PestelMethods objetoPestel = new PestelMethods();

        //                objetoPestel.Aspectonegativo = sr.aspectoNegativo;
        //                objetoPestel.AspectoPositivo = sr.aspectoPositivo;

        //                if (sr.Politico == true)
        //                {
        //                    objetoPestel.Politico = true;
        //                }

        //                if (sr.Economico == true)
        //                {
        //                    objetoPestel.Economico = true;
        //                }
        //                if (sr.Social == true)
        //                {
        //                    objetoPestel.Social = true;
        //                }
        //                if (sr.Tecnologico == true)
        //                {
        //                    objetoPestel.Tecnologico = true;
        //                }
        //                if (sr.Ecologico == true)
        //                {
        //                    objetoPestel.Ecologico = true;
        //                }
        //                if (sr.Legal == true)
        //                {
        //                    objetoPestel.Legal = true;
        //                }

        //                arrayPestel.Add(objetoPestel);
        //            }
        //            return arrayPestel;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
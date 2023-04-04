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


        private string _factor;
        private int _politico = 2;
        private int _economico = 2;
        private int _social = 2;
        private int _tecnologico = 2;
        private int _ecologico = 2;
        private int _legal = 2;

        public string Factor { get => _factor; set => _factor = value; }
        public int Politico { get => _politico; set => _politico = value; }
        public int Economico { get => _economico; set => _economico = value; }
        public int Social { get => _social; set => _social = value; }
        public int Tecnologico { get => _tecnologico; set => _tecnologico = value; }
        public int Ecologico { get => _ecologico; set => _ecologico = value; }
        public int Legal { get => _legal; set => _legal = value; }



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

        public ArrayList ListarPestel(int hojatrabajo)
        {

            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {

                    ArrayList arrayPestel = new ArrayList();
                    var query = from f in db.Factores
                                from p in db.Pestel
                                where f.Id_factor == p.Id_factor && p.Id_hoja_resultados == hojatrabajo && p.tipoFactor == true
                                select new
                                {
                                    f.aspectoPositivo,
                                    p.Politico,
                                    p.Economico,
                                    p.Social,
                                    p.Tecnologico,
                                    p.Ecologico,
                                    p.Legal
                                };

                    foreach (var sr in query)
                    {
                        PestelMethods objetoPestel = new PestelMethods();
                        objetoPestel.Factor = sr.aspectoPositivo;
                        if (sr.Politico == 1)
                        {
                            objetoPestel.Politico = 1;
                        }

                        if (sr.Economico == 1)
                        {
                            objetoPestel.Economico = 1;
                        }
                        if (sr.Social == 1)
                        {
                            objetoPestel.Social = 1;
                        }
                        if (sr.Tecnologico == 1)
                        {
                            objetoPestel.Tecnologico = 1;
                        }
                        if (sr.Ecologico == 1)
                        {
                            objetoPestel.Ecologico = 1;
                        }
                        if (sr.Legal == 1)
                        {
                            objetoPestel.Legal = 1;
                        }

                        if (sr.Politico == 0)
                        {
                            objetoPestel.Politico = 0;
                        }

                        if (sr.Economico == 0)
                        {
                            objetoPestel.Economico = 0;
                        }
                        if (sr.Social == 0)
                        {
                            objetoPestel.Social = 0;
                        }
                        if (sr.Tecnologico == 0)
                        {
                            objetoPestel.Tecnologico = 0;
                        }
                        if (sr.Ecologico == 0)
                        {
                            objetoPestel.Ecologico = 0;
                        }
                        if (sr.Legal == 0)
                        {
                            objetoPestel.Legal = 0;
                        }

                        arrayPestel.Add(objetoPestel);

                    }
                    var query2 = from f in db.Factores
                                 from p in db.Pestel
                                 where f.Id_factor == p.Id_factor && p.Id_hoja_resultados == hojatrabajo && p.tipoFactor == false
                                 select new
                                 {
                                     f.aspectoNegativo,
                                     p.Politico,
                                     p.Economico,
                                     p.Social,
                                     p.Tecnologico,
                                     p.Ecologico,
                                     p.Legal
                                 };

                    foreach (var sr in query2)
                    {
                        PestelMethods objetoPestel = new PestelMethods();

                        objetoPestel.Factor = sr.aspectoNegativo;


                        if (sr.Politico == 1)
                        {
                            objetoPestel.Politico = 1;
                        }

                        if (sr.Economico == 1)
                        {
                            objetoPestel.Economico = 1;
                        }
                        if (sr.Social == 1)
                        {
                            objetoPestel.Social = 1;
                        }
                        if (sr.Tecnologico == 1)
                        {
                            objetoPestel.Tecnologico = 1;
                        }
                        if (sr.Ecologico == 1)
                        {
                            objetoPestel.Ecologico = 1;
                        }
                        if (sr.Legal == 1)
                        {
                            objetoPestel.Legal = 1;
                        }

                        if (sr.Politico == 0)
                        {
                            objetoPestel.Politico = 0;
                        }

                        if (sr.Economico == 0)
                        {
                            objetoPestel.Economico = 0;
                        }
                        if (sr.Social == 0)
                        {
                            objetoPestel.Social = 0;
                        }
                        if (sr.Tecnologico == 0)
                        {
                            objetoPestel.Tecnologico = 0;
                        }
                        if (sr.Ecologico == 0)
                        {
                            objetoPestel.Ecologico = 0;
                        }
                        if (sr.Legal == 0)
                        {
                            objetoPestel.Legal = 0;
                        }

                        arrayPestel.Add(objetoPestel);
                    }

                    return arrayPestel;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
﻿using capa_datos;
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


        public int guardarPestel(int idFactor, string clasificacion, int politico, int economico, int social, int tecnologico, int ecologico, int legal, string justificacion, int idHojaResultado)
        {
            using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
            {
                try
                {
                    Pestel iPestel = new Pestel
                    {
                        Id_factor = idFactor,
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

                    var query = from i in db.Ideas
                                select i.Id_idea;
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }

        public ArrayList verInfoPestel(int hojatrabajo)
        {        
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    ArrayList arrayPestel = new ArrayList();
                    var query = from f in db.Factores
                                from p in db.Pestel
                                where f.Id_factor == p.Id_factor && p.Id_hoja_resultados == hojatrabajo
                                select new
                                {
                                    f.aspectoPositivo,
                                    f.aspectoNegativo,
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

                        objetoPestel.Aspectonegativo = sr.aspectoNegativo;
                        objetoPestel.AspectoPositivo = sr.aspectoPositivo;

                        if (sr.Politico == true)
                        {
                            objetoPestel.Politico = true;
                        }

                        if (sr.Economico == true)
                        {
                            objetoPestel.Economico = true;
                        }
                        if (sr.Social == true)
                        {
                            objetoPestel.Social = true;
                        }
                        if (sr.Tecnologico == true)
                        {
                            objetoPestel.Tecnologico = true;
                        }
                        if (sr.Ecologico == true)
                        {
                            objetoPestel.Ecologico = true;
                        }
                        if (sr.Legal == true)
                        {
                            objetoPestel.Legal = true;
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

        public void modificasrInfoPestel(int id, string clasificacion, bool economico, bool politico, bool social, bool tecnologico, bool ecologico, bool legal, string comentario)
        {
            try
            {
                //using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                //{
                //    Pestel new_pestel = new Pestel();
                //    new_pestel.Id_pestel = id;
                //    new_pestel.clasificacion_factor = clasificacion;
                //    new_pestel.Economico = economico;
                //    new_pestel.Social = social;
                //    new_pestel.Tecnologico = tecnologico;
                //    new_pestel.Ecologico = ecologico;
                //    new_pestel.Legal = legal;
                //    new_pestel.Comentario = comentario;

                //    db.Entry(new_pestel).State = System.Data.Entity.EntityState.Modified;
                //    db.SaveChanges();
                //}
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
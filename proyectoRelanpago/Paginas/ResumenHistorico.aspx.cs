﻿using Capa_Negocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace proyectoRelanpago.Paginas
{
    public partial class ResumenHistorico : System.Web.UI.Page
    {
        public PestelMethods nuevoresumen = new PestelMethods();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Usuario"] == null)
                {
                    Response.Redirect("~/Paginas/pagina_login.aspx", false);
                }
                else
                {
                    string idhojastring = Request.QueryString["idhoja"];
                    int idhoja = int.Parse(idhojastring);

                    _ = new ArrayList();

                    ArrayList factorespositivos = nuevoresumen.ListarPestel(idhoja);
                    StringBuilder politico = new StringBuilder();
                    StringBuilder economico = new StringBuilder();
                    StringBuilder social = new StringBuilder();
                    StringBuilder tecnologico = new StringBuilder();
                    StringBuilder ecologico = new StringBuilder();
                    StringBuilder legal = new StringBuilder();
                    foreach (PestelMethods carac in factorespositivos)
                    {
                        if (carac.Politico == 1)
                        {

                            politico.Append("<li class='factores'>" + carac.Factor + " (+) " + "</li>");
                        }

                        if (carac.Economico == 1)
                        {

                            economico.Append("<li class='factores'>" + carac.Factor + " (+) " + "</li>");

                        }

                        if (carac.Social == 1)
                        {
                            social.Append("<li class='factores'>" + carac.Factor + " (+) " + "</li>");
                        }

                        if (carac.Tecnologico == 1)
                        {

                            tecnologico.Append("<li class='factores'>" + carac.Factor + " (+) " + "</li>");
                        }

                        if (carac.Ecologico == 1)
                        {

                            ecologico.Append("<li class='factores'>" + carac.Factor + " (+) " + "</li>");
                        }

                        if (carac.Legal == 1)
                        {
                            legal.Append("<li class='factores'>" + carac.Factor + " (+) " + "</li>");
                        }

                        if (carac.Politico == 0)
                        {

                            politico.Append("<li class='factores'>" + carac.Factor + " (-) " + "</li>");
                        }

                        if (carac.Economico == 0)
                        {

                            economico.Append("<li class='factores'>" + carac.Factor + " (-) " + "</li>");

                        }

                        if (carac.Social == 0)
                        {
                            social.Append("<li class='factores'>" + carac.Factor + " (-) " + "</li>");
                        }

                        if (carac.Tecnologico == 0)
                        {

                            tecnologico.Append("<li class='factores'>" + carac.Factor + " (-) " + "</li>");
                        }

                        if (carac.Ecologico == 0)
                        {

                            ecologico.Append("<li class='factores'>" + carac.Factor + " (-) " + "</li>");
                        }

                        if (carac.Legal == 0)
                        {
                            legal.Append("<li class='factores'>" + carac.Factor + " (-) " + "</li>");
                        }
                    }
                    this.divpolitico.InnerHtml = politico.ToString();
                    this.diveconomico.InnerHtml = economico.ToString();
                    this.divsociales.InnerHtml = social.ToString();
                    this.divtecnologicos.InnerHtml = tecnologico.ToString();
                    this.divecologicos.InnerHtml = ecologico.ToString();
                    this.divlegales.InnerHtml = legal.ToString();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }

        protected void btnRedirigir_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Paginas/historico.aspx?", false);
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);                
            }
        }
    }
}
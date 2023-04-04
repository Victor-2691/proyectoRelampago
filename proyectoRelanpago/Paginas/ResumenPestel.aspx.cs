﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocios;

namespace proyectoRelanpago.Paginas
{
    public partial class ResumenPestel : System.Web.UI.Page
    {
        public PestelMethods nuevoresumen = new PestelMethods();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/Paginas/pagina_login.aspx", false);
            }
            else
            {
                if (Session["idHojaResultado"] != null)
                {
                    int idHojaResultado = (int)Session["idHojaResultado"];
                   
                    ArrayList factorespositivos = nuevoresumen.ListarPestel(idHojaResultado);
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
                else
                {
                    Response.Redirect("~/Paginas/Principal.aspx", false);
                }                   
            }            
        }

        protected void btnRedirigir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Principal.aspx?", false);

        }
    }
}
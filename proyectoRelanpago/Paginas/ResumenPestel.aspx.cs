using System;
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
            //_ = new ArrayList();

            //ArrayList resumen = nuevoresumen.verInfoPestel(26);
            //StringBuilder positivo = new StringBuilder();
            //StringBuilder negativo = new StringBuilder();


            //foreach (PestelMethods carac in resumen)
            //{
               
      
            //    if (carac.Politico == true)
            //    {
          
            //        negativo.Append("<li class='factores'>" + carac.Aspectonegativo +  "</li>");
            //        positivo.Append("<li class='factores'>" + carac.AspectoPositivo + "</li>");
            //        this.divpolitico.InnerHtml = negativo.ToString();
            //        this.divpolitico.InnerHtml = positivo.ToString();
            //    }

            //    if (carac.Economico == true)
            //    {
            
            //        negativo.Append("<li class='factores'>" + carac.Aspectonegativo + "</li>");
            //        positivo.Append("<li class='factores'>" + carac.AspectoPositivo + "</li>");
             
            //    }

            //    if (carac.Social == true)
            //    {
            //        negativo.Append("<li class='factores'>" + carac.Aspectonegativo + "</li>");
            //        positivo.Append("<li class='factores'>" + carac.AspectoPositivo + "</li>");
            //        this.divsociales.InnerHtml = negativo.ToString();
            //        this.divsociales.InnerHtml = positivo.ToString();
            //    }

            //    if (carac.Tecnologico == true)
            //    {
                 
            //        negativo.Append("<li class='factores'>" + carac.Aspectonegativo + "</li>");
            //        positivo.Append("<li class='factores'>" + carac.AspectoPositivo + "</li>");
            //        this.divtecnologicos.InnerHtml = negativo.ToString();
            //        this.divtecnologicos.InnerHtml = positivo.ToString();
            //    }

            //    if (carac.Ecologico == true)
            //    {
              
            //        negativo.Append("<li class='factores'>" + carac.Aspectonegativo + "</li>");
            //        positivo.Append("<li class='factores'>" + carac.AspectoPositivo + "</li>");
            //        this.divecologicos.InnerHtml = negativo.ToString();
            //        this.divecologicos.InnerHtml = positivo.ToString();
            //    }

            //    if (carac.Legal == true)
            //    {
                
            //        negativo.Append("<li class='factores'>" + carac.Aspectonegativo + "</li>");
            //        positivo.Append("<li class='factores'>" + carac.AspectoPositivo + "</li>");
            //        this.divlegales.InnerHtml = negativo.ToString();
            //        this.divlegales.InnerHtml = positivo.ToString();
            //    }
          
            //}
            //this.divpolitico.InnerHtml = negativoP.ToString();
            //this.divpolitico.InnerHtml = positivoP.ToString();
            //this.diveconomico.InnerHtml = negativoE.ToString();
            //this.diveconomico.InnerHtml = positivoE.ToString();

        }
    }
}
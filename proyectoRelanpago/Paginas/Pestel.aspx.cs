using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocios;

namespace proyectoRelanpago.Paginas
{
    public partial class Pestel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                obtenerFactores();
            }
        }

        private void obtenerFactores()
        {
            Factor iFactor = new Factor();
            //int idHojaResultado = (int)Session["idHojaResultado"];
            int idHojaResultado = 26;
            DataTable dtFactores = iFactor.obtenerFactores(idHojaResultado);

            StringBuilder infoFactores = new StringBuilder();
            StringBuilder modalFactores = new StringBuilder();
            foreach (DataRow drFactor in dtFactores.Rows)
            {
                infoFactores.Append("<tr>");
                infoFactores.Append("<td>" + drFactor["AspectoPositivo"] + "</td>");
                infoFactores.Append("<td>");
                infoFactores.Append("<button class='botonModal' type='button' data-toggle='modal' data-target='#FactorPositivo" + drFactor["idFactor"] + "'>");
                infoFactores.Append("<img class='imgPestel' src='../Recursos/signoMas_32.png' alt=''></button>");
                infoFactores.Append("</td>");
                infoFactores.Append("</tr>");

                infoFactores.Append("<tr>");
                infoFactores.Append("<td>" + drFactor["AspectoNegativo"] + "</td>");
                infoFactores.Append("<td>");
                infoFactores.Append("<button class='botonModal' type='button' data-toggle='modal' data-target='#FactorNegativo" + drFactor["idFactor"] + "'>");
                infoFactores.Append("<img class='imgPestel' src='../Recursos/signoMas_32.png' alt=''></button>");
                infoFactores.Append("</td>");
                infoFactores.Append("</tr>");

                // Modal Factor Positivo
                modalFactores.Append("<div class='modal fade' id='FactorPositivo" + drFactor["idFactor"] + "' tabindex='-1' role='dialog' aria-labelledby='exampleModalLabel' aria-hidden='true'>");
                modalFactores.Append("<div class='modal-dialog' role='document'>");
                modalFactores.Append("<div class='modal-content' style='background-color: #9dbab5'>");
                modalFactores.Append("<div class='modal-body'>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='clasificacion'>Clasificación</label>");
                modalFactores.Append("<select class='select' id='clasificacionPositivo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='1'>Interno</option>");
                modalFactores.Append("<option value='2'>Externo</option>");
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divPestel'>");
                modalFactores.Append("<div class='divParte'>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='politico'>Político</label>");
                modalFactores.Append("<select class='select' id='politicoPositivo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");               
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='tecnologico'>Tecnológico</label>");
                modalFactores.Append("<select class='select' id='tecnologicoPositivo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");               
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divParte'>");
                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='economico'>Económico</label>");
                modalFactores.Append("<select class='select' id='economicoPositivo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");               
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='ecologico'>Ecológico</label>");
                modalFactores.Append("<select class='select' id='ecologicoPositivo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");                
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divParte'>");
                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='social'>Social</label>");
                modalFactores.Append("<select class='select' id='socialPositivo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");                
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='legal'>Legal</label>");
                modalFactores.Append("<select class='select' id='legalPositivo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");                
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");

                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label'>Justificar clasificación (opcional)</label>");
                modalFactores.Append("<textarea class='comentario' id='comentarioFactorPositivo" + drFactor["idFactor"] + "'></textarea>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divBotonGuardar'>");
                modalFactores.Append("<input class='botonGuardar' type='button' id='btnGuardar' value='GUARDAR' onclick='guardar(\"" + drFactor["idFactor"] + "\", \"" + idHojaResultado + "\", 1 )'>");
                modalFactores.Append("</div>");

                modalFactores.Append("<input type='hidden' id='IDPestelPositivo" + drFactor["idFactor"] + "' value=''>");

                modalFactores.Append("</div>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");

                // Modal Factor Negativo
                modalFactores.Append("<div class='modal fade' id='FactorNegativo" + drFactor["idFactor"] + "' tabindex='-1' role='dialog' aria-labelledby='exampleModalLabel' aria-hidden='true'>");
                modalFactores.Append("<div class='modal-dialog' role='document'>");
                modalFactores.Append("<div class='modal-content' style='background-color: #9dbab5'>");
                modalFactores.Append("<div class='modal-body'>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='clasificacion'>Clasificación</label>");
                modalFactores.Append("<select class='select' id='clasificacionNegativo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='1'>Interno</option>");
                modalFactores.Append("<option value='2'>Externo</option>");
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divPestel'>");
                modalFactores.Append("<div class='divParte'>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='politico'>Político</label>");
                modalFactores.Append("<select class='select' id='politicoNegativo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");                
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='tecnologico'>Tecnológico</label>");
                modalFactores.Append("<select class='select' id='tecnologicoNegativo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");               
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divParte'>");
                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='economico'>Económico</label>");
                modalFactores.Append("<select class='select' id='economicoNegativo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");               
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='ecologico'>Ecológico</label>");
                modalFactores.Append("<select class='select' id='ecologicoNegativo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");               
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divParte'>");
                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='social'>Social</label>");
                modalFactores.Append("<select class='select' id='socialNegativo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");                
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label' for='legal'>Legal</label>");
                modalFactores.Append("<select class='select' id='legalNegativo" + drFactor["idFactor"] + "'>");
                modalFactores.Append("<option value='2'>N/A</option>");
                modalFactores.Append("<option value='1'>Positivo</option>");
                modalFactores.Append("<option value='0'>Negativo</option>");               
                modalFactores.Append("</select>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");

                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divClasificacion'>");
                modalFactores.Append("<label class='label'>Justificar clasificación (opcional)</label>");
                modalFactores.Append("<textarea class='comentario' id='comentarioFactorNegativo" + drFactor["idFactor"] + "'></textarea>");
                modalFactores.Append("</div>");

                modalFactores.Append("<div class='divBotonGuardar'>");
                modalFactores.Append("<input class='botonGuardar' type='button' id='btnGuardar' value='GUARDAR' onclick='guardar(\"" + drFactor["idFactor"] + "\", \"" + idHojaResultado + "\", 0 )'>");
                modalFactores.Append("</div>");

                modalFactores.Append("<input type='hidden' id='IDPestelNegativo" + drFactor["idFactor"] + "' value=''>");

                modalFactores.Append("</div>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");
                modalFactores.Append("</div>");
            }
            this.factores.InnerHtml = infoFactores.ToString();
            this.divModals.InnerHtml = modalFactores.ToString();
        }

        [WebMethod]
        public static object guardarPestel(int idFactor, int tipoFactor, int clasificacion, int politico, int economico, int social, int tecnologico, int ecologico, int legal, string justificacion, int idHojaResultado, string idPestel)
        {
            string idModificar = "";
            PestelMethods iPestel = new PestelMethods();

            if (idPestel.Trim().Equals(""))
            {
                int id = iPestel.guardarPestel(idFactor, tipoFactor, clasificacion, politico, economico, social, tecnologico, ecologico, legal, justificacion, idHojaResultado);
                idModificar = id.ToString();
            }
            else
            {
                iPestel.modificarPestel(int.Parse(idPestel),clasificacion, politico, economico, social, tecnologico, ecologico, legal, justificacion);
                idModificar = idPestel;
            }           
            return new { success = true, id = idModificar };
        }

        [WebMethod]
        public static object validarDatos()
        {
            return new { success = true };
        }
    }
}
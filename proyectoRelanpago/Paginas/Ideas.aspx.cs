using System;
using System.Collections;
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
    public partial class Ideas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/Paginas/pagina_login.aspx");
            }
            else
            {
                if (Session["idHojaResultado"] != null)
                {
                    int idHojaResultado = (int)Session["idHojaResultado"];
                    Caracteristica caracteristica = new Caracteristica();
                    ArrayList Caracteristicas = caracteristica.obtenerCaracteristicas(idHojaResultado);

                    StringBuilder infoCaracteristicas = new StringBuilder();
                    StringBuilder modalCaracteristicas = new StringBuilder();
                    foreach (Caracteristica carac in Caracteristicas)
                    {
                        infoCaracteristicas.Append("<div>");

                        infoCaracteristicas.Append("<input class='boton' type='button' value='" + carac.DescripcionCaracteristica + "' data-toggle='modal' data-target='#Caracteristica" + carac.IdCaracteristica + "' />");

                        infoCaracteristicas.Append("</div>");


                        modalCaracteristicas.Append("<div class='modal fade' id='Caracteristica" + carac.IdCaracteristica + "' tabindex='-1' role='dialog' aria-labelledby='exampleModalLabel' aria-hidden='true'>");
                        modalCaracteristicas.Append("<div class='modal-dialog' role='document'>");
                        modalCaracteristicas.Append("<div class='modal-content' style='background-color: #9dbab5'>");
                        modalCaracteristicas.Append("<div class='modal-body'>");

                        modalCaracteristicas.Append("<div class='divTituloIdeas'>");
                        modalCaracteristicas.Append("<p>Ideas</p>");
                        modalCaracteristicas.Append("</div>");

                        modalCaracteristicas.Append("<div class='divIdeas'>");

                        modalCaracteristicas.Append("<div>");
                        modalCaracteristicas.Append("<img src='../Recursos/number1_32.png' alt='Alternate Text' class='number' />");
                        modalCaracteristicas.Append("<input type='text' class='txt' name='IdeaCaracteristica" + carac.IdCaracteristica + "' autocomplete='off' placeholder='Idea 1'>");
                        modalCaracteristicas.Append("</div>");

                        modalCaracteristicas.Append("<div>");
                        modalCaracteristicas.Append("<img src='../Recursos/number2_32.png' alt='Alternate Text' class='number' />");
                        modalCaracteristicas.Append("<input type='text' class='txt' name='IdeaCaracteristica" + carac.IdCaracteristica + "' autocomplete='off' placeholder='Idea 2'>");
                        modalCaracteristicas.Append("</div>");

                        modalCaracteristicas.Append("<div>");
                        modalCaracteristicas.Append("<img src='../Recursos/number3_32.png' alt='Alternate Text' class='number' />");
                        modalCaracteristicas.Append("<input type='text' class='txt' name='IdeaCaracteristica" + carac.IdCaracteristica + "' autocomplete='off' placeholder='Idea 3'>");
                        modalCaracteristicas.Append("</div>");

                        modalCaracteristicas.Append("</div>");

                        modalCaracteristicas.Append("<div class='divBotonGuardar'>");
                        modalCaracteristicas.Append("<input class='botonGuardar' type='button' id='btnGuardar' value='GUARDAR' onclick='guardar(\"" + carac.IdCaracteristica  + "\")'>");
                        modalCaracteristicas.Append("</div>");

                        modalCaracteristicas.Append("</div>");

                        modalCaracteristicas.Append("</div>");

                        modalCaracteristicas.Append("</div>");
                        modalCaracteristicas.Append("</div>");
                    }

                    this.divCaracteristicas.InnerHtml = infoCaracteristicas.ToString();
                    this.divModals.InnerHtml = modalCaracteristicas.ToString();
                } 
                else
                {

                }                  
            }
        }

        [WebMethod]
        public static object guardarIdeas(string ideas, int idCaracteristica)
        {
            string[] arrayIdeas = ideas.Split(',');








            return new { success = true };           
        }
    }
}
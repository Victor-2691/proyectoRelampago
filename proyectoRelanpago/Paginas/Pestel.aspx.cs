using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
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
            foreach (DataRow drFactor in dtFactores.Rows)
            {
                infoFactores.Append("<tr>");
                infoFactores.Append("<td>" + drFactor["AspectoPositivo"] + "</td>");
                infoFactores.Append("<td>");
                infoFactores.Append("<button class='botonModal' type='button' data-toggle='modal' data-target='#exampleModal'>");
                infoFactores.Append("<img class='imgPestel' src='../Recursos/signoMas_32.png' alt=''></button>");
                infoFactores.Append("</td>");
                infoFactores.Append("</tr>");

                infoFactores.Append("<tr>");
                infoFactores.Append("<td>" + drFactor["AspectoNegativo"] + "</td>");
                infoFactores.Append("<td>");
                infoFactores.Append("<button class='botonModal' type='button' data-toggle='modal' data-target='#exampleModal'>");
                infoFactores.Append("<img class='imgPestel' src='../Recursos/signoMas_32.png' alt=''></button>");
                infoFactores.Append("</td>");
                infoFactores.Append("</tr>");
            }
            this.factores.InnerHtml = infoFactores.ToString();
        }
    }
}
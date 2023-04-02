using System;
using System.Collections.Generic;
using System.Linq;
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

        }

        [WebMethod]
        public static object guardarIdeas(string ideas, int idCaracteristica)
        {
            string[] arrayIdeas = ideas.Split(',');








            return new { success = true };           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoRelanpago
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Response.Redirect("~/Paginas/Principal.aspx", false);
            }
            else
            {
                Response.Redirect("~/Paginas/pagina_login.aspx", false);
            }            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoRelanpago.Paginas
{
    public partial class cerrarsesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
                Session["Usuario"] = null;
                Response.Redirect("~/Paginas/pagina_login.aspx",false);
             

            }
			catch (Exception ex)
			{


                ScriptManager.RegisterStartupScript(this, GetType(),
   "alert",
   "alert('" + ex.Message + "')", true);
            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocios;

namespace proyectoRelanpago.Paginas
{
    public partial class historico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HojaResultado hoconsulta = new HojaResultado();

            if (!Page.IsPostBack)
            {

                grdHistorico.DataSource = hoconsulta.VerHojasResultado();
                grdHistorico.DataBind();


            }


        }

        protected void grdHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
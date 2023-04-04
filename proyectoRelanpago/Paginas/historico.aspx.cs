using System;
using System.Collections.Generic;
using System.Data;
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
                DataTable dt = new DataTable();
                dt = hoconsulta.VerHojasResultado();
               

                grdHistorico.DataSource = hoconsulta.VerHojasResultado();
                grdHistorico.DataBind();


            }


        }

        protected void grdHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        protected void grdHistorico_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            string idhoja;

         
            try
            {
                if (e.CommandName == "Reporte")
                {
                    int index = int.Parse(e.CommandArgument.ToString());
                    GridViewRow fila = grdHistorico.Rows[index];
                    idhoja = fila.Cells[0].Text;

                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
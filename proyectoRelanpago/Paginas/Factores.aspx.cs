using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocios;

namespace proyectoRelanpago.Paginas
{
    public partial class Factores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/Paginas/pagina_login.aspx", false);
            }
            else
            {
                Session["idHojaResultado"] = 41;

                if (Session["idHojaResultado"] != null)
                {
                    if (!Page.IsPostBack)
                    {
                        //ingresarFactoresNull();
                        DataTable dtFactores = consultarFactores();
                        grdFactores.DataSource = dtFactores;
                        grdFactores.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("~/Paginas/Principal.aspx", false);
                }
            }
        }

        protected void grdFactores_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdFactores.EditIndex = e.NewEditIndex;

            DataTable dtFactores = consultarFactores();
            grdFactores.DataSource = dtFactores;
            grdFactores.DataBind();
        }

        protected void grdFactores_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idFactor = Convert.ToInt32(grdFactores.DataKeys[e.RowIndex].Value.ToString());

            string aspectoPositivo = ((TextBox)grdFactores.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string aspectoNegativo = ((TextBox)grdFactores.Rows[e.RowIndex].Cells[4].Controls[0]).Text;

            Factor iFactor = new Factor();
            iFactor.modificarFactor(idFactor, aspectoPositivo, aspectoNegativo);

            grdFactores.EditIndex = -1;

            DataTable dtFactores = consultarFactores();
            grdFactores.DataSource = dtFactores;
            grdFactores.DataBind();
        }

        protected void grdFactores_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdFactores.EditIndex = -1;

            DataTable dtFactores = consultarFactores();
            grdFactores.DataSource = dtFactores;
            grdFactores.DataBind();
        }

        private void ingresarFactoresNull()
        {
            Idea iIdeas = new Idea();
            int idHojaResultado = (int)Session["idHojaResultado"];           
            ArrayList ideas = iIdeas.obtenerIdeas(idHojaResultado);

            Factor iFactor = new Factor();
            foreach (Idea idea in ideas)
            {
                iFactor.ingresarFactoresNull(idea.IdIdea, idHojaResultado);
            }
        }

        private DataTable consultarFactores()
        {
            Factor iFactor = new Factor();
            //int idHojaResultado = (int)Session["idHojaResultado"];

            int idHojaResultado = 41;

            DataTable dtFactores = iFactor.obtenerFactores(idHojaResultado);
            return dtFactores;
        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Pestel.aspx", false);
        }
    }
}
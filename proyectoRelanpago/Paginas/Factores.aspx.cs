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
            try
            {
                if (Session["Usuario"] == null)
                {
                    Response.Redirect("~/Paginas/pagina_login.aspx", false);
                }
                else
                {
                    if (Session["idHojaResultado"] != null)
                    {
                        if (!Page.IsPostBack)
                        {
                            ingresarFactoresNull();
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
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }

        protected void grdFactores_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                grdFactores.EditIndex = e.NewEditIndex;

                DataTable dtFactores = consultarFactores();
                grdFactores.DataSource = dtFactores;
                grdFactores.DataBind();
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }

        protected void grdFactores_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }

        protected void grdFactores_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                grdFactores.EditIndex = -1;

                DataTable dtFactores = consultarFactores();
                grdFactores.DataSource = dtFactores;
                grdFactores.DataBind();
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }

        private void ingresarFactoresNull()
        {
            try
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
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }

        private DataTable consultarFactores()
        {
            try
            {
                Factor iFactor = new Factor();
                int idHojaResultado = (int)Session["idHojaResultado"];

                DataTable dtFactores = iFactor.obtenerFactores(idHojaResultado);
                return dtFactores;
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
                return null;
            }
        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Paginas/Pestel.aspx", false);
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }
    }
}
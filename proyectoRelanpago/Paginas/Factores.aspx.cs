using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoRelanpago.Paginas
{
    public partial class Factores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Caracteristica", typeof(string));
                dt.Columns.Add("Idea", typeof(string));
                dt.Columns.Add("AspectoPositivo", typeof(string));
                dt.Columns.Add("AspectoNegativo", typeof(string));

                DataRow Row1;
                Row1 = dt.NewRow();
                Row1["ID"] = "1";
                Row1["Caracteristica"] = "Estudiante de escasos recursos";
                Row1["Idea"] = "Programas técnicos o capacitaciones rápidas con mercado laboral";
                Row1["AspectoPositivo"] = "";
                Row1["AspectoNegativo"] = "";

                dt.Rows.Add(Row1);

                grdFactores.DataSource = dt;
                grdFactores.DataBind();
            }
        }

        protected void grdFactores_RowEditing(object sender, GridViewEditEventArgs e)
        {

            grdFactores.EditIndex = e.NewEditIndex;
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Caracteristica", typeof(string));
            dt.Columns.Add("Idea", typeof(string));
            dt.Columns.Add("AspectoPositivo", typeof(string));
            dt.Columns.Add("AspectoNegativo", typeof(string));

            DataRow Row1;
            Row1 = dt.NewRow();
            Row1["ID"] = "1";
            Row1["Caracteristica"] = "Estudiante de escasos recursos";
            Row1["Idea"] = "Programas técnicos o capacitaciones rápidas con mercado laboral";
            Row1["AspectoPositivo"] = "";
            Row1["AspectoNegativo"] = "";

            dt.Rows.Add(Row1);

            grdFactores.DataSource = dt;
            grdFactores.DataBind();
        }

        protected void grdFactores_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(grdFactores.DataKeys[e.RowIndex].Value.ToString());

            string aspectoPositivo = ((TextBox)grdFactores.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string aspectoNegativo = ((TextBox)grdFactores.Rows[e.RowIndex].Cells[4].Controls[0]).Text;

            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Caracteristica", typeof(string));
            dt.Columns.Add("Idea", typeof(string));
            dt.Columns.Add("AspectoPositivo", typeof(string));
            dt.Columns.Add("AspectoNegativo", typeof(string));

            DataRow Row1;
            Row1 = dt.NewRow();
            Row1["ID"] = "1";
            Row1["Caracteristica"] = "Estudiante de escasos recursos";
            Row1["Idea"] = "Programas técnicos o capacitaciones rápidas con mercado laboral";
            Row1["AspectoPositivo"] = aspectoPositivo;
            Row1["AspectoNegativo"] = aspectoNegativo;

            dt.Rows.Add(Row1);

            grdFactores.EditIndex = -1;

            grdFactores.DataSource = dt;
            grdFactores.DataBind();
        }

        protected void grdFactores_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdFactores.EditIndex = -1;
        }
    }
}
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

            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Caracteristica", typeof(string));
            dt.Columns.Add("Idea", typeof(string));
            dt.Columns.Add("AspectoPositivo", typeof(string));
            dt.Columns.Add("AspectoNegativo", typeof(string));

            DataRow Row1;
            Row1 = dt.NewRow();
            Row1["ID"] = "1";
            Row1["Caracteristica"] = "sdasdaasdsadasdasdsda";
            Row1["Idea"] = "ssdasdsdasdasadasd";  
            Row1["AspectoPositivo"] = "saasasasdasasds";
            Row1["AspectoNegativo"] = "sadassdaasdsdaasd";

            dt.Rows.Add(Row1);

            grdFactores.DataSource = dt;
            grdFactores.DataBind();
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
            Row1["Caracteristica"] = "sdasdaasdsadasdasdsda";
            Row1["Idea"] = "ssdasdsdasdasadasd";
            Row1["AspectoPositivo"] = "saasasasdasasds";
            Row1["AspectoNegativo"] = "sadassdaasdsdaasd";

            dt.Rows.Add(Row1);

            grdFactores.DataSource = dt;
            grdFactores.DataBind();
        }
    }
}
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

            dt.Columns.Add("Característica", typeof(string));
            dt.Columns.Add("Idea", typeof(string));
            dt.Columns.Add("Aspecto positivo", typeof(string));
            dt.Columns.Add("Aspecto negativo", typeof(string));

            DataRow Row1;
            Row1 = dt.NewRow();
            Row1["Característica"] = "sdasdaasdsadasdasdsda";
            Row1["Idea"] = "ssdasdsdasdasadasd";  
            Row1["Aspecto positivo"] = "saasasasdasasds";
            Row1["Aspecto negativo"] = "sadassdaasdsdaasd";

            dt.Rows.Add(Row1);

            grdFactores.DataSource = dt;
            grdFactores.DataBind();
        }
    }
}
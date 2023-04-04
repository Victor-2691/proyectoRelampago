using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoRelanpago.Paginas
{
    public partial class pagina_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Usuario"] != null)
                {
                    Response.Redirect("~/Paginas/Principal.aspx", false);
                }
                else
                {
                    txt_usuario.Attributes.Add("placeholder", "Usuario");
                    txt_contra.Attributes.Add("placeholder", "Contraseña");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);               
            }          
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioMethods login = new UsuarioMethods();
                bool iniciasesion = login.login(txt_usuario.Text.Trim(), txt_contra.Text.Trim());
                if (iniciasesion)
                {
                    Session["Usuario"] = txt_usuario.Text.Trim();
                    Response.Redirect("~/Paginas/Principal.aspx", false);
                }
                else
                {
                    Session["Usuario"] = null;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toast", $"Alerta('Usuario y/o contraseña incorrectos')", true);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }
    }
}
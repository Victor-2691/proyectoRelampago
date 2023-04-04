using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocios;

namespace proyectoRelanpago.Paginas
{
    public partial class pagina_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_usuario.Attributes.Add("placeholder", "Usuario");
            txt_contra.Attributes.Add("placeholder", "Contraseña");
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
                    Response.Redirect("~/Default.aspx", false);
                }
                else
                {
                    Session["Usuario"] = null;
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                  "alert", "alert('" + "Usuario o contraseña incorrectos" + "')", true);


                    ScriptManager.RegisterStartupScript(this, GetType(), "alert",
                   "Swal.fire('Good job!','You clicked the button!','success')", true);

                }

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
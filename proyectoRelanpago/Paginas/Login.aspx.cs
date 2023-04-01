using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoRelanpago.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_usuario.Attributes.Add("placeholder", "Usuario");
            txt_contra.Attributes.Add("placeholder", "Contraseña");

        }
    }
}
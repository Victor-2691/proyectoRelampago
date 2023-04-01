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
            txt_usuario.Attributes.Add("placeholder", "Usuario");
            txt_contra.Attributes.Add("placeholder", "Contraseña");

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {

            metodosBD login = new metodosBD();
            login.selectusuarios();
        }
    }
}
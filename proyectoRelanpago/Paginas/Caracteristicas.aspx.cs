﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocios;
using WebGrease.ImageAssemble;

namespace proyectoRelanpago.Paginas
{
    public partial class Caracteristicas : System.Web.UI.Page
    {
        public Capa_Negocios.Caracteristica c1 = new Capa_Negocios.Caracteristica();

        public Capa_Negocios.HojaResultado hoja = new Capa_Negocios.HojaResultado();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Usuario"] == null)
                {
                    Response.Redirect("~/Paginas/pagina_login.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex;
                Response.Redirect("~/Paginas/Error", false);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCarac1.Text.Trim() == "" || txtCarac2.Text.Trim() == ""
              || txtCarac3.Text.Trim() == "" || txtCarac4.Text.Trim() == "" || txtCarac5.Text.Trim() == "")
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toast", $"Alerta('La cantidad mínima de características debe ser de 5')", true);
                }
                else
                {
                    //*Insertamos la Hoja de trabajo*/
                    string usuario = (string)Session["Usuario"];
                    DateTime fecha = DateTime.Now;
                    bool estado = false;
                    int numerohoja = hoja.agregarhojatrabajo(usuario, fecha, estado);

                    Session["idHojaResultado"] = numerohoja;

                    //*Insertamos las caracteristicas en un ciclo*/
                    String[] arraycaracteristicas = new String[10];
                    arraycaracteristicas[0] = txtCarac1.Text.Trim();
                    arraycaracteristicas[1] = txtCarac2.Text.Trim();
                    arraycaracteristicas[2] = txtCarac3.Text.Trim();
                    arraycaracteristicas[3] = txtCarac4.Text.Trim();
                    arraycaracteristicas[4] = txtCarac5.Text.Trim();
                    arraycaracteristicas[5] = txtCarac6.Text.Trim();
                    arraycaracteristicas[6] = txtCarac7.Text.Trim();
                    arraycaracteristicas[7] = txtCarac8.Text.Trim();
                    arraycaracteristicas[8] = txtCarac9.Text.Trim();
                    arraycaracteristicas[9] = txtCarac10.Text.Trim();

                    for (int i = 0; i < arraycaracteristicas.Length; i++)
                    {
                        if (arraycaracteristicas[i] != "")
                        {
                            c1.agregarCaracteristica(usuario, numerohoja, arraycaracteristicas[i]);
                        }
                    }

                    Response.Redirect("~/Paginas/Ideas.aspx", false);
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
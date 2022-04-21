using Ejercicio.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio.vista
{
    public partial class frm_venta : System.Web.UI.Page
    {
        ventaRepositorio vp = new ventaRepositorio();
        void cargargrilla()
        {
            var consulta = vp.Consultar();
            gvVentas.DataSource = consulta;
            gvVentas.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargargrilla();
            }


        }


        protected void gvVentas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int Identificador = Convert.ToInt32(e.CommandArgument);
                vp.Eliminar(Identificador);
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Venta Eliminada ');</script>");
                cargargrilla();
            }


        }




    }
}
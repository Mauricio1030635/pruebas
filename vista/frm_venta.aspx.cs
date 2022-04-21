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
            try { 
            if (!Page.IsPostBack)
            {
                cargargrilla();
            }
        }catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Error en tiempo de ejecucion');</script>");
                string ruta = String.Empty;
                ruta = Server.MapPath(@"..\recursos\Log" + DateTime.Now.ToString("MMMM yyyy") + ".txt");
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta);
                archivo.WriteLine("*******************************************");
                archivo.WriteLine(DateTime.Now.ToString());
                archivo.WriteLine("Page_Load");
                archivo.WriteLine("frm_venta");
                archivo.WriteLine(ex.Message.ToString() + ex);
                archivo.WriteLine("*******************************************");
                archivo.Close();
              }


}


        protected void gvVentas_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            try { 
            if (e.CommandName == "Eliminar")
            {
                int Identificador = Convert.ToInt32(e.CommandArgument);
                vp.Eliminar(Identificador);
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Venta Eliminada ');</script>");
                cargargrilla();
            }

        }catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Error en tiempo de ejecucion');</script>");
                string ruta = String.Empty;
                ruta = Server.MapPath(@"..\recursos\Log" + DateTime.Now.ToString("MMMM yyyy") + ".txt");
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta);
                archivo.WriteLine("*******************************************");
                archivo.WriteLine(DateTime.Now.ToString());
                archivo.WriteLine("gvVentas_RowCommand");
                archivo.WriteLine("frm_venta");
                archivo.WriteLine(ex.Message.ToString() + ex);
                archivo.WriteLine("*******************************************");
                archivo.Close();
              }



}




    }
}
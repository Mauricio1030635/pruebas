using Ejercicio.dto;
using Ejercicio.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio.vista
{
    public partial class frm_marcas : System.Web.UI.Page
    {
        marcaRepositorio mc = new marcaRepositorio();

        void cargargrilla()
        {
            var consulta = mc.Consultar();
            gvMarcas.DataSource = consulta;
            gvMarcas.DataBind();
        }


       
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                    {
                        cargargrilla();
                    }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Error en tiempo de ejecucion');</script>");
                string ruta = String.Empty;
                ruta = Server.MapPath(@"..\recursos\Log" + DateTime.Now.ToString("MMMM yyyy") + ".txt");
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta);
                archivo.WriteLine("*******************************************");
                archivo.WriteLine(DateTime.Now.ToString());
                archivo.WriteLine("Page_Load");
                archivo.WriteLine("frm_marcas");
                archivo.WriteLine(ex.Message.ToString() + ex);
                archivo.WriteLine("*******************************************");
                archivo.Close();
            }
        }

        protected void gvMarcas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Modificar") {
                var Identificador = e.CommandArgument;
            }

            if (e.CommandName == "Eliminar")
            {
                var Identificador = e.CommandArgument;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
          try
            {
                marcaDTO nuevo = new marcaDTO();            
                nuevo.Descripcion = txtDescripcion.Text; 
                string valor = mc.Agregar(nuevo);
                txtDescripcion.Text="";
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('"+valor+ "');</script>");
                cargargrilla();
        }catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Error en tiempo de ejecucion');</script>");
                string ruta = String.Empty;
                ruta = Server.MapPath(@"..\recursos\Log" + DateTime.Now.ToString("MMMM yyyy") + ".txt");
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta);
                archivo.WriteLine("*******************************************");
                archivo.WriteLine(DateTime.Now.ToString());
                archivo.WriteLine("btnAgregar_Click");
                archivo.WriteLine("frm_marcas");
                archivo.WriteLine(ex.Message.ToString() + ex);
                archivo.WriteLine("*******************************************");
                archivo.Close();
              }
}
    }
}
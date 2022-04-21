using Ejercicio.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio.vista
{
    public partial class frm_consultar : System.Web.UI.Page
    {
        consultaRepositorio cr = new consultaRepositorio();
        void cargargrilla()
        {
            
            gvConsulta.DataSource = null;
            gvConsulta.DataBind();
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
             try { 
                cargargrilla();                  
            }catch(Exception ex)
            {
                    ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Error en tiempo de ejecucion');</script>");
                    string ruta = String.Empty;
                    ruta = Server.MapPath(@"..\recursos\Log" + DateTime.Now.ToString("MMMM yyyy") + ".txt");
                    System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta);
                    archivo.WriteLine("*******************************************");
                    archivo.WriteLine(DateTime.Now.ToString());
                    archivo.WriteLine("Page_Load");
                    archivo.WriteLine("frm_consultar");
                    archivo.WriteLine(ex.Message.ToString() + ex);
                    archivo.WriteLine("*******************************************");
                    archivo.Close();

                }  
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                 var info =cr.Consultar(Convert.ToInt64(txtconsulta.Text));
                 gvConsulta.DataSource = info;
                 gvConsulta.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Error en tiempo de ejecucion');</script>");
                string ruta = String.Empty;
                ruta = Server.MapPath(@"..\recursos\Log" + DateTime.Now.ToString("MMMM yyyy") + ".txt");
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta);
                archivo.WriteLine("*******************************************");
                archivo.WriteLine(DateTime.Now.ToString());
                archivo.WriteLine("btnBuscar_Click");
                archivo.WriteLine("frm_consultar");
                archivo.WriteLine(ex.Message.ToString() + ex);
                archivo.WriteLine("*******************************************");
                archivo.Close();

            }
        }
    }
}
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
    public partial class frm_vendedor : System.Web.UI.Page
    {
        vendedorRepositorio vr = new vendedorRepositorio();

         void cargargrilla()
        {
            var consulta = vr.Consultar();
            gvVendedor.DataSource = consulta;
            gvVendedor.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
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
                archivo.WriteLine("frm_vendedor");
                archivo.WriteLine(ex.Message.ToString() + ex);
                archivo.WriteLine("*******************************************");
                archivo.Close();
              }


}


        protected void gvVendedor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Modificar")
            {
                int Identificador = Convert.ToInt32(e.CommandArgument);
                vendedorDTO vendedor =  vr.buscar(Identificador);
                txtcedula.Text = vendedor.Cedula.ToString();
                txtnombre.Text = vendedor.Nombre.ToString();
                txtapellido.Text = vendedor.Apellido.ToString();
                txtedad.Text = vendedor.Edad.ToString();
                txtTelefono.Text = vendedor.Telefono.ToString();
                txtId.Value = vendedor.ID.ToString();
                btnAgregar.Visible = false;
                btnModificar.Visible = true;                
            }
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Error en tiempo de ejecucion');</script>");
                string ruta = String.Empty;
                ruta = Server.MapPath(@"..\recursos\Log" + DateTime.Now.ToString("MMMM yyyy") + ".txt");
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta);
                archivo.WriteLine("*******************************************");
                archivo.WriteLine(DateTime.Now.ToString());
                archivo.WriteLine("Page_Load");
                archivo.WriteLine("frm_vendedor");
                archivo.WriteLine(ex.Message.ToString() + ex);
                archivo.WriteLine("*******************************************");
                archivo.Close();
              }

           
        }


        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vendedorDTO vendedor = new vendedorDTO();
                vendedor.Cedula =Convert.ToInt64(txtcedula.Text);
                vendedor.Nombre = txtnombre.Text;
                vendedor.Apellido = txtapellido.Text;
                vendedor.Edad = Convert.ToByte(txtedad.Text);
                vendedor.Telefono = txtTelefono.Text;
                vendedor.ID = Convert.ToInt32(txtId.Value);
                string valor = vr.Modificar(vendedor);
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('" + valor + "');</script>");
                limpiar();
                cargargrilla();
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('Error en tiempo de ejecucion');</script>");
                string ruta = String.Empty;
                ruta = Server.MapPath(@"..\recursos\Log" + DateTime.Now.ToString("MMMM yyyy") + ".txt");
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta);
                archivo.WriteLine("*******************************************");
                archivo.WriteLine(DateTime.Now.ToString());
                archivo.WriteLine("Page_Load");
                archivo.WriteLine("frm_vendedor");
                archivo.WriteLine(ex.Message.ToString() + ex);
                archivo.WriteLine("*******************************************");
                archivo.Close();
              }

}

        public void limpiar() {
            txtcedula.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txtTelefono.Text = "";
            txtId.Value = "";
            btnAgregar.Visible = true;
            btnModificar.Visible = false;

        }

    }
}
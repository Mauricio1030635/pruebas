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
            if (!Page.IsPostBack)
            {
                cargargrilla();
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
            marcaDTO nuevo = new marcaDTO();            
            nuevo.Descripcion = txtDescripcion.Text; 
            string valor = mc.Agregar(nuevo);
            txtDescripcion.Text="";
            ClientScript.RegisterStartupScript(typeof(Page), "Alerta", @"<script language = ""JavaScript"">alert('"+valor+ "');</script>");
            cargargrilla();
        }
    }
}
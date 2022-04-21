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
                cargargrilla();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var info =cr.Consultar(Convert.ToInt64(txtconsulta.Text));
            gvConsulta.DataSource = info;
            gvConsulta.DataBind();            
        }
    }
}
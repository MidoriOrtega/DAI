using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPaginaWeb
{
    public partial class Modificaciones : System.Web.UI.Page
    {
        protected OdbcConnection conectarBD()
        {
            String stringConexion = "Driver={SQL Server Native Client 11.0};Server=localhost;Database=claseDAI18; trusted_connection=Yes";
            try
            {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkbtnAltas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1.aspx");
        }

        protected void lnkbtnBajas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Baja.aspx");
        }
    }
}
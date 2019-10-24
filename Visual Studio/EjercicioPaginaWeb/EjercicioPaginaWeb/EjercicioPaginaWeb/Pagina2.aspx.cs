using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPaginaWeb
{
    public partial class Pagina2 : System.Web.UI.Page
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
            if (!IsPostBack)
            {
               
                OdbcConnection miConexion = conectarBD();
                if (miConexion != null)
                {
                    String query = String.Format("select datosAlumnos18.nombre from datosAlumnos18");
                    OdbcCommand cmd = new OdbcCommand(query, miConexion);
                    OdbcDataReader rd = cmd.ExecuteReader();
                    ddlAlumnos.Items.Clear();
                    while (rd.Read())
                    {
                        ddlAlumnos.Items.Add(rd.GetString(0));
                    }
                    rd.Close();
                    miConexion.Close();
                }
            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        protected void lnkbtnAltas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1.aspx");
        }

        protected void lnkbtnCambios_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina3.aspx");
        }
    }
}
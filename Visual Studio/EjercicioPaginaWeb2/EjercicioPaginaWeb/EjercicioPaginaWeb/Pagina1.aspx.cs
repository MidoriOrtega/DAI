using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPaginaWeb
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected OdbcConnection conectarBD()
        {
            String stringConexion = "Driver={SQL Server Native Client 11.0};Server=localhost;Database=claseDAI18; trusted_connection=Yes";
            try
            {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                lblResultado.Text = "Conexion exitosa";
                return conexion;
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.StackTrace.ToString();
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btRegistrar_Click(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
            String query;
            if (miConexion != null)
            {
                query = String.Format("insert into datosAlumno18 values({0}, '{1}', '{2}', '{3}')", 0, txtCorreo.Text, txtPassword.Text, txtNombre);
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    Response.Redirect("Pagina2.aspx");
                }
                rd.Close();
                miConexion.Close();
            }
        }

        protected void lnkbtnCambios_Click(object sender, EventArgs e)
        {

            Response.Redirect("Modificaciones.aspx");
        }

        protected void lnkbtnBajas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Baja.aspx");
        }
    }
}
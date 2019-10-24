using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPaginaWeb
{
    public partial class Pagina3 : System.Web.UI.Page
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
                    ddlAlumno.Items.Clear();
                    while (rd.Read())
                    {
                        ddlAlumno.Items.Add(rd.GetString(0));
                    }
                    rd.Close();
                    miConexion.Close();
                }
            }

        }

        protected void lnkbtnAltas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1.aspx");
        }

        protected void lnkbtnBajas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina2.aspx");
        }

        protected void ddlAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int claveU = 0;
            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                String query = String.Format("select nombre from  datosAlumnos18 where nombre='{0}'", ddlAlumno.SelectedValue);
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    claveU = rd.GetInt16(0);
                    String query2 = String.Format("select datosAlumnos.correo from datosAlumnos18 where datosAlumnos18.ID=();
                    OdbcCommand cmd = new OdbcCommand(query2, miConexion);
                    OdbcDataReader rd2 = cmd.ExecuteReader();
                    rd2.Read();
                    txtCorreo.Text = rd2.GetString(0);
                    rd2.Close();
                }
                rd.Close();
            }
        }
    }
}
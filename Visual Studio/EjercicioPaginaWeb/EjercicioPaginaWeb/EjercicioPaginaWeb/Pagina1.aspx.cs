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
                lblResultado.Text = "Conexión exitosa";
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

        private int creacionID()
        {
            int resp;
            resp = -1;
            OdbcConnection miConexion = conectarBD();
            String query;
            if (miConexion != null)
            {
                query = String.Format("select MAX(id) from datosAlumno18");
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    resp = Convert.ToInt16(rd.GetString(0)) + 1;
                    /*try
                    {
                        resp = Convert.ToInt16(rd.GetString(0)) + 1;
                    }
                    catch(Exception e)
                    {
                        resp = 1;
                    }                    
                    else
                    {
                        //lblResultado.Text = "else";
                        resp = Convert.ToInt16(rd.GetString(0)) + 1;
                    }*/
                rd.Close();
                miConexion.Close();                
            }
            return resp;
        }

        private int repetido()
        {
            OdbcConnection miConexion = conectarBD();
            int resp = -1;
            String query;
            List<String> l1, l2;
            l1 = new List<String>();
            l2 = new List<String>();
            if (miConexion != null)
            {
                query = String.Format("select correo, nombre from datosAlumno18");
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    l1.Add(rd.GetString(0));
                    l2.Add(rd.GetString(1));                    
                }
                rd.Close();
                miConexion.Close();
            }
            if (l1 != null && l2 != null) {
                int i = 0;
                while (i < l1.Count())
                {
                    if (txtCorreo.Text.Equals(l1[i]))
                    {
                        int j = 0;
                        while (j < l2.Count())
                        {
                            if (txtNombre.Text.Equals(l2[j]))
                            {
                                resp = 1;
                                j = l2.Count();
                                i = l1.Count();
                            }
                            else
                                j++;
                        }                        
                    }
                    else
                        i++;                    
                }
            }           
            return resp;
        }

        protected void btRegistrar_Click(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
            String query;
            int d;
            if (miConexion != null)
            {
                if (repetido() < 0)
                {
                    d = 0;
                    if (d == 0)
                    {
                        d = 1;
                        query = String.Format("insert into datosAlumno18 values(1, '{0}', '{1}', '{2}')", txtCorreo.Text, txtPassword.Text, txtNombre.Text);
                        OdbcCommand cmd = new OdbcCommand(query, miConexion);
                        cmd.ExecuteNonQuery();
                        Response.Redirect("Pagina2.aspx");
                        miConexion.Close();
                    }
                    else
                    {
                        query = String.Format("insert into datosAlumno18 values({0}, '{1}', '{2}', '{3}')", creacionID(), txtCorreo.Text, txtPassword.Text, txtNombre.Text);
                        OdbcCommand cmd = new OdbcCommand(query, miConexion);
                        cmd.ExecuteNonQuery();
                        Response.Redirect("Pagina2.aspx");
                        miConexion.Close();
                    }
                }
                else
                    lblResultado.Text = "Ya hay un alumno con ese nombre o correo registrado";
            }
            else
                lblResultado.Text = "Falló la conexión";
        }

        protected void lnkbtnBajas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina2.aspx");
        }

        protected void lnkbtnCambios_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina3.aspx");
        }

        protected void btnInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina4.aspx");
        }
    }
}
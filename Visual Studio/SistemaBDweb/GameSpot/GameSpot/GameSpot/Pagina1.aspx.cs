﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace GameSpot
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected OdbcConnection conectarBD()
        {
            String stringConexion = "Driver={SQL Server Native Client 11.0};Server=localhost;Database=GameSpot; trusted_connection=Yes";
            try
            {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                lbContador.Text = "Conexion exitosa";
                return conexion;
            }
            catch (Exception ex)
            {
                lbContador.Text = ex.StackTrace.ToString();
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            txUsuario.Text = "juan@gmail.com";
            txContraseña.Text = "juanito";


        }

        protected void btPagina2_Click(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
            String query;
            if (miConexion != null)
            {
                query = "select claveU from usuario where email='" + txUsuario.Text + "' and password='" + txContraseña.Text + "'";
                // query = String.Format("select claveU from usuario where email='{0}' and password='{1}'", txUsuario.Text, txContraseña.Text);
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows) // ¿Tiene contenido?
                {
                    rd.Read();
                    Session["claveUnica"] = rd.GetString(0);
                    Response.Redirect("Pagina2.aspx");
                }
                else
                    lbContador.Text = "ERROR: Usuario o contraseña incorrecto";
                rd.Close();
                miConexion.Close();
            }
        } 


    }
}
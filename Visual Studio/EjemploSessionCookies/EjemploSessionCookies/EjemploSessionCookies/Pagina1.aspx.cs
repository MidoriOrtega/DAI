using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploSessionCookies
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Un refrescamiento de la página para que solo lo haga primera vez
            {// La página es la primera vez o es un retroceso
                Application.Lock(); // Para que no se incremente de manera inecesaria 
                Application["Usuarios"] = Convert.ToInt16(Application["Usuarios"]) + 1;
                Application.UnLock();
                lblContador.Text = Application["Usuarios"].ToString();
            }
            Page.Title = (String)Application["Empresa"]; // Le ponemos nombre a la pestaña de la página que asignamos en la global.asax

        }

        protected void btnPagina2_Click(object sender, EventArgs e)
        {
            Session["session"] = txtUsuario.Text;
            HttpCookie cookie1 = new HttpCookie("password", txtPassword.Text);
            cookie1.Expires = new DateTime(2019, 12, 25);
            Response.Cookies.Add(cookie1);
            Response.Redirect("Pagina2.aspx");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usoControles
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si no lo pones cada vez que actualizas te agrega los items de nuevo
            if(drdColores.Items.Count == 0) 
            {
                drdColores.Items.Add("Rojo");
                drdColores.Items.Add("Verde");
                drdColores.Items.Add("Azul");
                drdColores.Items.Add("Rosa");
            }
            if(rdbSabores.Items.Count == 0)
            {
                rdbSabores.Items.Add("Vainilla");
                rdbSabores.Items.Add("Fresa");
                rdbSabores.Items.Add("Limón");
                rdbSabores.Items.Add("Chocolate");
            }

            if(cbl1.Items.Count == 0)
            {
                cbl1.Items.Add("Americano");
                cbl1.Items.Add("Capuchino");
                cbl1.Items.Add("Latte");
                cbl1.Items.Add("Té");
            }
        }

        protected void drdColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = 0;
            seleccion = drdColores.SelectedIndex;
            lbl1.Text = "Índice seleccionado: " + seleccion.ToString();
            Session["controles"] = "Cambió a drdColores";
            lblSession.Text = Session["controles"].ToString();
        }

        protected void rdbSabores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl2.Text = "Índice seleccionado: " + rdbSabores.SelectedIndex.ToString();
            lbl3.Text = "Valor seleccionado: " + rdbSabores.SelectedValue.ToString();
            Session["controles"] = "Cambió a rdbSabores";
            lblSession.Text = Session["controles"].ToString();
        }

        protected void cbl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltb1.Items.Clear();
            ltb2.Items.Clear();
            for (int i = 0; i < cbl1.Items.Count; i++)
            {
                if (cbl1.Items[i].Selected == true)
                {
                    ltb1.Items.Add(i.ToString());
                    ltb2.Items.Add(cbl1.Items[i].Value.ToString());
                }
            }
            Session["controles"] = "Cambió a cbl1";
            lblSession.Text = Session["controles"].ToString();
        }
    }
}
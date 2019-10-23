using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace SistemaAlumnos
{
    class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection cnn = null;
            try
            {
                cnn = new SqlConnection("Data Source=localhost;Initial Catalog=baseSistemaAlumno;Integrated Security=True");
                cnn.Open();
                MessageBox.Show("Se pudo conectar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar y el error es: " + ex);
            }
            return cnn;
        }

        public static String comprobarUsuPwd(String usuario, String contra)
        {
            String res = "";
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader drd;
            try
            {
                con = Conexion.conectar();
                cmd = new SqlCommand(String.Format("select contra from usuarios where nombreUsuario = '{0}' ", usuario), con);
                drd = cmd.ExecuteReader();
                if (drd.Read())
                {
                    if (drd.GetString(0).Equals(contra))
                        res = "Contraseña correcta";
                    else
                        res = "ERROR: Contraseña incorrecta";
                }
                else
                    res = "ERROR: Usuario incorrecto";
                con.Close();
                drd.Close();
            }
            catch (Exception ex)
            {
                res = "ERROR:" + ex;
            }
            return res;
        }

        public static void llenarComboAlta(ComboBox cb)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader drd;
            try
            {
                con = Conexion.conectar();
                cmd = new SqlCommand("select nombre from programa", con);
                drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    cb.Items.Add(drd["nombre"].ToString());
                }
                cb.SelectedIndex = 0;
                con.Close();
                drd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: No se pudo llenar el combo");
            }
        }





    }
}

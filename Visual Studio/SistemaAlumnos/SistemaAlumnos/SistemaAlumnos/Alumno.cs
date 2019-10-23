using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Alumno
    {
        public Int16 claveUnica { get; set; }
        public String nombre { get; set; }
        public String sexo { get; set; }
        public String correo { get; set; }
        public Int16 semestre { get; set; }
        public int programa { get; set; }

        public Alumno()
        {
        }

        public Alumno(short claveUnica)
        {
            this.claveUnica = claveUnica;
        }

        public Alumno(string nombre)
        {
            this.nombre = nombre;
        }

        public Alumno(short claveUnica, string correo) : this(claveUnica)
        {
            this.correo = correo;
        }

        public Alumno(short claveUnica, string nombre, string sexo, string correo, short semestre, int programa)
        {
            this.claveUnica = claveUnica;
            this.nombre = nombre;
            this.sexo = sexo;
            this.correo = correo;
            this.semestre = semestre;
            this.programa = programa;
        }

        public int alta(Alumno a)
        {
            int res = 0;
            // Abrir mi conexión
            SqlConnection con;
            con = Conexion.conectar();
            // Hacer el query
            SqlCommand cmd = new SqlCommand(String.Format("insert into alumno(claveUnica, nombre, sexo, correo, semestre, idPrograma) values({0}, '{1}', '{2}', '{3}', {4}, {5})", a.claveUnica, a.nombre, a.sexo, a.correo, a.semestre, a.programa), con);
            // Ejecutar el query
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int baja(Alumno a)
        {
            int res = 0;
            // Abrir mi conexión
            SqlConnection con;
            con = Conexion.conectar();
            // Hacer el query
            SqlCommand cmd = new SqlCommand(String.Format("delete from alumno where claveUnica = {0}", a.claveUnica), con);
            // Ejecutar el query
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int modifica(Alumno a)
        {
            int res = 0;
            // Abrir mi conexión
            SqlConnection con;
            con = Conexion.conectar();
            // Hacer el query
            SqlCommand cmd = new SqlCommand(String.Format("update alumno set correo = '{0}' where claveUnica = {1}", a.correo, a.claveUnica), con);
            // Ejecutar el query
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public List<Alumno> busca(Alumno a)
        {
            SqlDataReader drd;
            List<Alumno> lis = new List<Alumno>();
            Alumno aux;
            // Abrir mi conexión
            SqlConnection con;
            con = Conexion.conectar();
            // Hacer el query
            SqlCommand cmd = new SqlCommand(String.Format("select * from alumno where nombre like '%{0}%'", a.nombre), con);
            // Ejecutar el query
            drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                aux = new Alumno();
                aux.claveUnica = drd.GetInt16(0);
                aux.nombre = drd.GetString(1);
                aux.sexo = drd.GetString(2);
                aux.correo = drd.GetString(3);
                aux.semestre = drd.GetInt16(4);
                aux.programa = drd.GetInt16(5);

                lis.Add(aux);
            }
            con.Close();
            return lis;
        }
    }
}

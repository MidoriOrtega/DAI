using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaAlumnos
{
    /// <summary>
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void tbModificar_Click(object sender, RoutedEventArgs e)
        {
            int res;
            Alumno a;
            a = new Alumno(Int16.Parse(tbFolio.Text), tbCorreo.Text);
            res = a.modifica(a);
            if (res > 0)
                MessageBox.Show("Se modificó");
            else
                MessageBox.Show("ERROR: No se modificó");
        }

        private void tbRegresar_Click(object sender, RoutedEventArgs e)
        {
            Alta w = new Alta();
            w.Show();
            this.Hide();
        }
    }
}

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
    /// Lógica de interacción para Baja.xaml
    /// </summary>
    public partial class Baja : Window
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void btBaja_Click(object sender, RoutedEventArgs e)
        {
            int res;
            Alumno a;
            a = new Alumno(Int16.Parse(tbFolio.Text));
            res = a.baja(a);
            if (res > 0)
                MessageBox.Show("Se dio de baja");
            else
                MessageBox.Show("ERROR: No se dio de baja");
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            Alta w = new Alta();
            w.Show();
            this.Hide();
        }
    }
}

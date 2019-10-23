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
    /// Lógica de interacción para Alta.xaml
    /// </summary>
    public partial class Alta : Window
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion.llenarComboAlta(cbProgramas);
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            int res;
            Alumno a;
            a = new Alumno(Int16.Parse(txtClaveUnica.Text), txtNombre.Text, txtSexo.Text, txtCorreo.Text, Int16.Parse(txtSemestre.Text), cbProgramas.SelectedIndex);
            res = a.alta(a);
            if (res > 0)
                MessageBox.Show("Se dio de alta");
            else
                MessageBox.Show("ERROR: No se dio de alta");
        }

        private void btEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Baja w = new Baja();
            w.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Buscar w = new Buscar();
            w.Show();
        }

        private void btModificar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modificar w = new Modificar();
            w.Show();
        }

        private void btSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

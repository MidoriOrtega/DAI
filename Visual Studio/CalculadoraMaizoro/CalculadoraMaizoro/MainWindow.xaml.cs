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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Convertidor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox objTextBox = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BttCalcular_Click(object sender, RoutedEventArgs e)
        {
            try {
                double grados;
                // Si escribió en la caja de txtCentígrados
                if (objTextBox == txtCentigrados) {
                    MessageBox.Show("Escribiste en la txtCemtigrados");
                    grados = Convert.ToDouble(txtCentigrados.Text) * 9.0 / 5.0 + 32;
                    // Muestra con número con 2 decimales
                    txtFahrenheit.Text = String.Format("{0:F2}", grados);
                }
                else {
                    // Si escribió en la caja de txtFahrenheit
                    if (objTextBox == txtFahrenheit)
                    {
                        MessageBox.Show("Escribiste en la txtFahrenheit");
                        grados = (Convert.ToDouble(txtFahrenheit.Text) - 32) * 5.0 / 9.0;
                        txtCentigrados.Text = String.Format("{0:F2}", grados);
                    }
                }
            }
            catch (FormatException) {
                txtCentigrados.Text = "0.0";
                txtFahrenheit.Text = "32.0";
            }

        }

        private void TxtCentigrados_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            objTextBox = sender as TextBox;
        }

        private void TxtFahrenheit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            objTextBox = sender as TextBox;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtCentigrados.Focus();
        }
    }
}

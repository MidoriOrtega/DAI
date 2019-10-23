﻿using System;
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

namespace CalculadoraMaizoro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BttCalcular_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbSuma.IsChecked)
                suma();
            else
                resta();

        }
        public void suma()
        {
            txtResultado.Text = "" + (Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text));
        }
        public void resta()
        {
            txtResultado.Text = "" + (Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text));
        }
    }
}
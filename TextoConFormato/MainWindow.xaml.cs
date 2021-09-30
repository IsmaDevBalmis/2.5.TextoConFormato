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

namespace TextoConFormato
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textoIntroducidoTextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            mostrarTextoTextBlock.Text = textoIntroducidoTextBlock.Text;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            mostrarTextoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            mostrarTextoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            mostrarTextoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            mostrarTextoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void colorAzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            mostrarTextoTextBlock.Foreground = Brushes.Blue;
        }

        private void colorRojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            mostrarTextoTextBlock.Foreground = Brushes.Red;
        }

        private void colorVerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            mostrarTextoTextBlock.Foreground = Brushes.Green;
        }
    }
}

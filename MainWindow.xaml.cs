using Capitulo8_9WPF.Capitulo_8;
using Capitulo8_9WPF.Capitulo_9;
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

namespace Capitulo8_9WPF
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

        private void ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio3().Show();
            
        }

        private void ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio5().Show();
         }

        private void ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio1().Show();
        }

        private void ejercicio3menuItems_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio3Cap9().Show();
        }
    }
}

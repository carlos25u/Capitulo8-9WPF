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

namespace Capitulo8_9WPF.Capitulo_9
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, RoutedEventArgs e)
        {
            new Tienda(int.Parse(codigotextBox.Text), nombreTextBox.Text);

            codigotextBox.Text = "";
            nombreTextBox.Text = "";
        }
    }
    
}
public struct Tienda{
    int codigo;
    String nombre;

    public Tienda(int cod, String nom)
    {
        codigo = cod;
        nombre = nom;
    }
}
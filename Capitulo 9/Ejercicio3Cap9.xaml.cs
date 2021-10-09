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
    /// Interaction logic for Ejercicio3Cap9.xaml
    /// </summary>
    public partial class Ejercicio3Cap9 : Window
    {
        public Ejercicio3Cap9()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, RoutedEventArgs e)
        {
            new Veterinaria(dueñotextBox.Text, mascotaTextBox.Text);

            dueñotextBox.Text = "";
            mascotaTextBox.Text = "";
        }
    }
}
public struct Veterinaria
{
    String duenno;
    String mascota;

    public Veterinaria(String due, String mas)
    {
        duenno = due;
        mascota = mas;
    }
}
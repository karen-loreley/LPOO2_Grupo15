using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for ABMClientes.xaml
    /// </summary>
    public partial class ABMClientes : Window
    {
        public ABMClientes()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            string mensaje = "Estas seguro que deseas guardar estos datos?";
            MessageBoxResult resultado = MessageBox.Show(mensaje, "confirmacion", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultado == MessageBoxResult.Yes)
            {
                string nom = textnom.Text;
                string ape = textape.Text;
                int dni = int.Parse(textdni.Text);
                string telefono = texttel.Text;


                Cliente cliente = new Cliente();

                cliente.nombre = nom;
                cliente.apellido = ape;
                cliente.clienteDNI = dni;
                cliente.telefono = telefono;

                MessageBox.Show("El nombre del cliente es: " + nom + ", El apellido es: " + ape + ", su DNI es:" + dni + " Y su telefono es:" + telefono);

            }
            else
            {
                MessageBox.Show("no se ha guardado los datos");
            }
        }
    }
}

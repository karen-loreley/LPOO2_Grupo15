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
    /// Interaction logic for ABMTipoVehiculos.xaml
    /// </summary>
    public partial class ABMTipoVehiculos : Window
    {
        public ABMTipoVehiculos()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            string mensaje = "Estas seguro que deseas guardar estos datos?";
            MessageBoxResult resultado = MessageBox.Show(mensaje, "confirmacion", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultado == MessageBoxResult.Yes)
            {
                string des = textdescripcion.Text;
                int cod = int.Parse(textcodigo.Text);
                decimal tar = decimal.Parse(texttarifa.Text);

                TipoVehiculo vehiculo = new TipoVehiculo();

                vehiculo.tvcodigo = cod;
                vehiculo.descripcion = des;
                vehiculo.tarifa = tar;

                MessageBox.Show("El codigo del vehiculo es: " + cod + ", La descripcion es: " + des + "y la tarifa es:" + tar );

            }
            else
            {
                MessageBox.Show("no se ha guardado los datos");
            }
        }

        private void btnplaya_Click(object sender, RoutedEventArgs e)
        {

            VehiculoPlaya vehiculo = new VehiculoPlaya();
            this.Close();
            vehiculo.Show();
        }
    }
}

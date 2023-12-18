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

using System.Windows;

namespace TalonHallintaSovellus
{
    public partial class MainWindow : Window
    {
        // Muuttujat talon tilan seuraamiseksi
        private float lämpötila;
        private bool keittiöValot;
        private bool olohuoneenValot;
        private bool oviLukossa;

        public MainWindow()
        {
            InitializeComponent();

            // Alustetaan muuttujat
            lämpötila = 20.0f;  // Oletuslämpötila
            keittiöValot = false;
            olohuoneenValot = false;
            oviLukossa = false;
        }

        private void ValotPäällePoisButton_Click(object sender, RoutedEventArgs e)
        {
            // Käsittele valojen päälle/pois -toiminto
            keittiöValot = !keittiöValot;
            olohuoneenValot = !olohuoneenValot;

            // Lisää tarvittava logiikka valojen päälle/pois kytkemiseksi
            // esimerkiksi valo-ohjauslaitteiston kautta.
            MessageBox.Show("Valot päälle/pois -toiminto käynnistetty");
        }

        private void LukitseAvaaOviButton_Click(object sender, RoutedEventArgs e)
        {
            // Käsittele oven lukitseminen/avaaminen
            oviLukossa = !oviLukossa;

            // Tässä voit lisätä koodin oven lukitsemiseksi/avaamiseksi.
        }
    }

}

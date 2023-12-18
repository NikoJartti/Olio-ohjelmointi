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

namespace harjoitus_22
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
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtWidth.Text, out double width) &&
                double.TryParse(txtHeight.Text, out double height) &&
                double.TryParse(txtFrameWidth.Text, out double frameWidth))
            {
                double perimeter = 2 * (width + height);
                double glassArea = width * height;
                double windowArea = (width + 2 * frameWidth) * (height + 2 * frameWidth);

              
                txtResults.Text = $"Karmin piiri: {perimeter:F2} cm\n";
                txtResults.Text += $"Lasin pinta-ala: {glassArea:F2} cm²\n";
                txtResults.Text += $"Ikkunan Pinta-ala: {windowArea:F2} cm²";
            }
            else
            {
                txtResults.Text = "Syötä kelvolliset arvot kaikkiin kenttiin.";
            }
        }
    }
}


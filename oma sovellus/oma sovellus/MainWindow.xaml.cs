using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace oma_sovellus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        private ObservableCollection<Muistiinpano> muistiinpanot;

        public MainWindow()
        {
            InitializeComponent();
            muistiinpanot = new ObservableCollection<Muistiinpano>();
            lstMuistiinpanot.ItemsSource = muistiinpanot;
        }

        private void Lisää(object sender, RoutedEventArgs e)
        {
            string sisalto = txtMuistiinpano.Text.Trim();

            if (!string.IsNullOrEmpty(sisalto))
            {
                Muistiinpano uusiMuistiinpano = new Muistiinpano(sisalto);
                muistiinpanot.Add(uusiMuistiinpano);
                txtMuistiinpano.Clear();
                txtTila.Text = "";
            }
            else
            {
                txtTila.Text = "Kirjoita muistiinpano ensin.";
            }
        }

        private void Poista(object sender, RoutedEventArgs e)
        {
            if (lstMuistiinpanot.SelectedItem is Muistiinpano valittuMuistiinpano)
            {
                muistiinpanot.Remove(valittuMuistiinpano);
                txtTila.Text = "Muistiinpano poistettu.";
            }
            else
            {
                txtTila.Text = "Valitse poistettava muistiinpano.";
            }
        }

        private void Valittu(object sender, RoutedEventArgs e)
        {
            if (lstMuistiinpanot.SelectedItem is Muistiinpano valittuMuistiinpano)
            {
                txtTila.Text = $"Valittu muistiinpano: {valittuMuistiinpano.Sisalto}";
            }
        }
    }

    public class Muistiinpano
    {
        public string Sisalto { get; }

        public Muistiinpano(string sisalto)
        {
            Sisalto = sisalto;
        }
    }
}

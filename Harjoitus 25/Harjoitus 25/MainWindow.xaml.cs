using System;
using System.Collections.Generic;
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


namespace Harjoitus_25
{
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int PelaajaNumero { get; set; }
        public string Joukkue { get; set; }
    }

    public class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; } = new List<Pelaaja>();
    }

    public partial class MainWindow : Window
    {
        private List<Joukkue> joukkueet = new List<Joukkue>();
        private string jsonTiedosto = "joukkueet.json";

        public MainWindow()
        {
            InitializeComponent();
            LataaJoukkueet();
            PäivitäDataGridit();
        }

        private void PäivitäDataGridit()
        {
            dataGridJoukkueet.ItemsSource = null;
            dataGridJoukkueet.ItemsSource = joukkueet;

            // Voit lisätä toisen DataGridin pelaajille tarvittaessa
            // dataGridPelaajat.ItemsSource = null;
            // dataGridPelaajat.ItemsSource = valitunJoukkueenPelaajat;
        }

        private void LataaJoukkueet()
        {
            try
            {
                if (File.Exists(jsonTiedosto))
                {
                    string json = File.ReadAllText(jsonTiedosto);
                    joukkueet = JsonConvert.DeserializeObject<List<Joukkue>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe luettaessa joukkueita: {ex.Message}", "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TallennaJoukkueet()
        {
            try
            {
                string json = JsonConvert.SerializeObject(joukkueet, Formatting.Indented);
                File.WriteAllText(jsonTiedosto, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tallennettaessa joukkueita: {ex.Message}", "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void lisääJoukkueButton_Click(object sender, RoutedEventArgs e)
        {
            Joukkue uusiJoukkue = new Joukkue();
            joukkueet.Add(uusiJoukkue);
            PäivitäDataGridit();
        }

        private void poistaJoukkueButton_Click(object sender, RoutedEventArgs e)
        {
            Joukkue valittuJoukkue = dataGridJoukkueet.SelectedItem as Joukkue;
            if (valittuJoukkue != null)
            {
                joukkueet.Remove(valittuJoukkue);
                PäivitäDataGridit();
            }
        }

        private void tallennaButton_Click(object sender, RoutedEventArgs e)
        {
            TallennaJoukkueet();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TallennaJoukkueet();
        }
    }
}
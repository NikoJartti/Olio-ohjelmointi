using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace harjoitus_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [Serializable]
        public class Opiskelija
        {
            public string Etunimi { get; set; }
            public string Sukunimi { get; set; }
            public int OpiskelijaID { get; set; }
            public string Sähköposti { get; set; }
            public string Puhelinnumero { get; set; }
        }        
        private List<Opiskelija> opiskelijat = new List<Opiskelija>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLuoOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            Opiskelija uusiOpiskelija = new Opiskelija
            {
                Etunimi = "Matti",
                Sukunimi = "Meikäläinen",
                OpiskelijaID = 1,
                Sähköposti = "matti.meikalainen@example.com",
                Puhelinnumero = "123456789"
            };

            if (!OpiskelijaIDJaSähköpostiUniikkeja(uusiOpiskelija))
            {
                MessageBox.Show("OpiskelijaID tai sähköposti ei ole uniikki!");
                return;
            }

            opiskelijat.Add(uusiOpiskelija);
            PäivitäNäkymä();
        }

        private bool OpiskelijaIDJaSähköpostiUniikkeja(Opiskelija uusiOpiskelija)
        {
            foreach (var opiskelija in opiskelijat)
            {
                if (opiskelija.OpiskelijaID == uusiOpiskelija.OpiskelijaID || opiskelija.Sähköposti == uusiOpiskelija.Sähköposti)
                {
                    return false;
                }
            }
            return true;
        }

        private void PäivitäNäkymä()
        {
            stockPanel.Children.Clear();

            foreach (var opiskelija in opiskelijat)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = $"{opiskelija.Etunimi} {opiskelija.Sukunimi}, ID: {opiskelija.OpiskelijaID}, Email: {opiskelija.Sähköposti}, Puh: {opiskelija.Puhelinnumero}";
                stockPanel.Children.Add(textBlock);
            }
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("opiskelijat.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, opiskelijat);
            }
            MessageBox.Show("Opiskelijan tiedot tallennettu tiedostoon.");
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream("opiskelijat.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    opiskelijat = (List<Opiskelija>)formatter.Deserialize(fs);
                }
                MessageBox.Show("Opiskelijan tiedot ladattu tiedostosta.");
                PäivitäNäkymä();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe ladattaessa tiedostoa: {ex.Message}");
            }
        }
    }
}


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

namespace Harjoitus_24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tulosta_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtRivienMaara.Text, out int rivienMaara))
            {
                Pelivalinta peli = GetValittuPeli();

                for (int i = 0; i < rivienMaara; i++)
                {
                    ArvoRivi(peli);
                }
            }
            else
            {
                MessageBox.Show("Anna kelvollinen luku rivejen määrälle.");
            }
        }

        private void Tyhjenna_Click(object sender, RoutedEventArgs e)
        {
            txtArvotutRivit.Text = "";
        }

        private Pelivalinta GetValittuPeli()
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cmbPelivalinta.SelectedItem;
            string valittuPeli = selectedItem.Content.ToString();

            switch (valittuPeli)
            {
                case "Lotto":
                    return Pelivalinta.Lotto;
                case "Viking Lotto":
                    return Pelivalinta.VikingLotto;
                case "Eurojackpot":
                    return Pelivalinta.Eurojackpot;
                default:
                    throw new ArgumentException("Virhe valittaessa peliä.");
            }
        }

        private void ArvoRivi(Pelivalinta peli)
        {
            List<int> numerot = ArvoNumerot(peli);

            string rivi = $"Rivi {txtArvotutRivit.Inlines.Count / 2 + 1}: {string.Join(", ", numerot)}\n";
            txtArvotutRivit.Inlines.Add(new Run(rivi));
        }

        private List<int> ArvoNumerot(Pelivalinta peli)
        {
            int arvottujenMaara = (peli == Pelivalinta.Lotto) ? 7 : 6;
            List<int> numerot = new List<int>();

            while (numerot.Count < arvottujenMaara)
            {
                int arvottuNumero = random.Next(1, (peli == Pelivalinta.Lotto) ? 40 : 48);

                if (!numerot.Contains(arvottuNumero))
                {
                    numerot.Add(arvottuNumero);
                }
            }

            numerot.Sort();
            return numerot;
        }

        private enum Pelivalinta
        {
            Lotto,
            VikingLotto,
            Eurojackpot
        }
    }
}

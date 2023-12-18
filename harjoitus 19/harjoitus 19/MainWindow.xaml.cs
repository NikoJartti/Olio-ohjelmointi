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

namespace harjoitus_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hissi hissi;

        public MainWindow()
        {
            InitializeComponent();
            hissi = new Hissi();
        }

        private void SiirryKerrokseenButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(KerrosTextBox.Text, out int valittuKerros))
            {
                if (hissi.SetKerros(valittuKerros))
                {
                    MessageBox.Show($"Siirrytty kerrokseen {valittuKerros}");
                }
                else
                {
                    MessageBox.Show("Virheellinen kerros. Valitse kerros väliltä 1 - 6.");
                }
            }
            else
            {
                MessageBox.Show("Virheellinen syöte. Anna numero väliltä 1 - 6.");
            }
        }
    }

    public class Hissi
    {
        private int nykyinenKerros;

        public int NykyinenKerros
        {
            get { return nykyinenKerros; }
        }

        public bool SetKerros(int uusiKerros)
        {
            if (uusiKerros >= 1 && uusiKerros <= 6)
            {
                nykyinenKerros = uusiKerros;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

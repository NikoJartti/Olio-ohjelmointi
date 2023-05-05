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

namespace harjoitus_15__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int henkilöAutot = 0;
        private int kuormaAutot = 0;
        public MainWindow()
        {
            InitializeComponent();

            tbHenkilöauto.Text = henkilöAutot.ToString();
            tbKuormaauto.Text = kuormaAutot.ToString();
        }

        private void btnKuormaauto_Click(object sender, RoutedEventArgs e)
        {
            kuormaAutot++;
            tbKuormaauto.Text = kuormaAutot.ToString();
        }

        private void btnHenkilöauto_Click_1(object sender, RoutedEventArgs e)
        {
            henkilöAutot++;
            tbHenkilöauto.Text = henkilöAutot.ToString();
        }
    }
}

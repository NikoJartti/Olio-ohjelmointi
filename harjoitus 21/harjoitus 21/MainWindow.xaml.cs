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

namespace harjoitus_21
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
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            TextBlock textBlock = new TextBlock();
            textBlock.Text = checkBox.Content.ToString();
            StockPanel.Children.Add(textBlock);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            TextBlock textBlockToRemove = null;

            foreach (var child in StockPanel.Children)
            {
                if (child is TextBlock textBlock && textBlock.Text == checkBox.Content.ToString())
                {
                    textBlockToRemove = textBlock;
                    break;
                }
            }

            if (textBlockToRemove != null)
            {
                StockPanel.Children.Remove(textBlockToRemove);
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var child in StockPanel.Children)
            {
                if (child is TextBlock textBlock)
                {
                    string productName = textBlock.Text;
                    CheckBox checkBox = FindName("chk" + productName.Replace(" ", "")) as CheckBox;
                    if (checkBox != null)
                    {
                        checkBox.IsChecked = false;
                    }
                }
            }
            StockPanel.Children.Clear();
        }
    }
}


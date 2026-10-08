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

namespace Trailer_Rental
{
    /// <summary>
    /// Interaction logic for LeasingAgreementsView.xaml
    /// </summary>
    public partial class LeasingAgreementsView : UserControl
    {
        public LeasingAgreementsView()
        {
            InitializeComponent();
        }

        private void LeasingAgreementViewButtonBackToStartView_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;

            mainwindow.MainContent.Content = new StartView();
        }

        private void SaveDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Document is being saved",
                "Document saved!",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void PrinDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Document is being printed",
                "Document printed",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void PrintEmptyDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Empty document is being printed",
                "Document printed!",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}

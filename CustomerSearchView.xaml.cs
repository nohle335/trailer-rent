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
    public partial class CustomerSearchView : UserControl
    {
        public CustomerSearchView()
        {
            InitializeComponent();
        }

        private void LeasingAgreementViewButtonBackToStartView_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;

            mainwindow.MainContent.Content = new StartView();
        }
    }
}


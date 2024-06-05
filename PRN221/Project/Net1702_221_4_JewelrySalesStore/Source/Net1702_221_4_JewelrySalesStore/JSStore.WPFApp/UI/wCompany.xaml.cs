using JewelrySalesStoreBusiness;
using JewelrySalesStoreData.Models;
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
using System.Windows.Shapes;

namespace JewelrySalesStoreWPFApp.UI
{
    /// <summary>
    /// Interaction logic for wCompany.xaml
    /// </summary>
    public partial class wCompany : Window
    {
        private readonly CompanyBusiness _business;
        public wCompany()
        {
            InitializeComponent();
            _business = new CompanyBusiness();
            LoadGridCompanies();

        }
        private async void ButtonSave_Click(object sender, RoutedEventArgs e) { }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e) { }
        private async void grdCompany_ButtonDelete_Click(object sender, RoutedEventArgs e) { }
        private async void grdCompany_ButtonEdit_Click(object sender, RoutedEventArgs e) { }
        
        private async void grdCompany_MouseDouble_Click(object sender, RoutedEventArgs e) { }

        private async void LoadGridCompanies()
        {

            var result = await _business.GetAll();

            if (result.Status > 0 && result.Data != null)
            {
                gridCompany.ItemsSource = result.Data as List<Company>;
            }
            else
            {
                gridCompany.ItemsSource = new List<Company>();
            }

        }

    }
}
